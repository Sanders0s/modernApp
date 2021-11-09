using GalaSoft.MvvmLight.Messaging;
using modernApp.Core;
using modernApp.Core.Enum;
using modernApp.MVM.Model;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace modernApp.MVM.ViewModels
{
    public class DiscoveryViewModel : ObservableObject
    {
        private IMessenger messenger;
        private ObservableCollection<DogBreed> _dogBreedsList;
        private int counter = 1;
        private string breed;
        private DogColours colour;

        private string mess;
        public string Mess
        {
            get
            {
                return mess;
            }
            set
            {
                mess = value;
            }
        }
        public string Breed
        {
            get
            {
                return breed;
            }
            set
            {
                breed = value;
                OnPropertyChanged();
            }
        }
        public DogColours Colour
        {
            get
            {
                return colour;
            }
            set
            {
                colour = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<DogBreed> DogBreedsList
        {
            get
            {
                return _dogBreedsList;
            }
            set
            {
                _dogBreedsList = value;
                OnPropertyChanged();
            }
        }
        public DiscoveryViewModel(IMessenger messenger)
        {
            this.messenger = messenger;
            this.messenger = new Messenger();
        }

        public DiscoveryViewModel()
        {

            _dogBreedsList = new ObservableCollection<DogBreed>();
            _dogBreedsList.Add(new DogBreed { Id = counter, Breed = "Labrador", Colour = DogColours.black });
            counter++;
            _dogBreedsList.Add(new DogBreed { Id = counter, Breed = "Daschund", Colour = DogColours.brown });
            counter++;

            Messenger.Default.Register<NotificationMessage>(this, (message) =>
            {
                mess = message.Notification;
            });
        }

        public void NotifyMe(NotificationMessage message)
        {
            string token = message.Notification;
        }

        public void AddDog()
        {
            if (breed is not null and not "")
            {
                DogBreed newItem = new() { Id = counter++, Breed = Breed, Colour = Colour };
                _dogBreedsList.Add(newItem);
                string addBreed = newItem.Breed;

            }
            else
            {
                MessageBox.Show("Nie udało się dodać. Spróbuj ponownie");
            }
        }

        public void RemoveDog(int id)
        {
            DogBreed user = _dogBreedsList.FirstOrDefault(x => x.Id == id);
            _dogBreedsList.Remove(user);
            MessageBox.Show("Pomyślnie usunięto podany rekord");
        }
    }
}
