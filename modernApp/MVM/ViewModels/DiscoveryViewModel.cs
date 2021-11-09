using DevExpress.Xpo.Logger;
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
        private ILogger logger;
        private IMessenger messenger;
        private ObservableCollection<DogBreed> dogBreedsList;
        private string breed;
        private DogColours colour;

        public string Message { get; set; }

        public string Breed
        {
            get{return breed;}
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
                return dogBreedsList;
            }
            set
            {
                dogBreedsList = value;
                OnPropertyChanged();
            }
        }

        public DiscoveryViewModel()
        {
            messenger = new Messenger();
            dogBreedsList = new ObservableCollection<DogBreed>
            {
            new DogBreed { Id = 1, Breed = "Labrador", Colour = DogColours.Black },
            new DogBreed { Id = 2, Breed = "Daschund", Colour = DogColours.Brown }
            };
            messenger.Register<NotificationMessage>(this, (message) =>
            {
                Message = message.Notification;
            });
        }

        public void AddDog()
        {
            if (!string.IsNullOrEmpty(breed))
            {
                DogBreed newItem = new() { Id = dogBreedsList.Count+1, Breed = Breed, Colour = Colour };
                dogBreedsList.Add(newItem);
            }
            else
            {
                logger.Log(new LogMessage(LogMessageType.Text, "Nie udało się dodać. Spróbuj ponownie"));
            }
        }

        public void RemoveDog(int id)
        {
            DogBreed user = dogBreedsList.FirstOrDefault(x => x.Id == id);
            dogBreedsList.Remove(user);
            logger.Log(new LogMessage(LogMessageType.Text, "Pomyślnie usunięto podany rekord"));
        }
    }
}
