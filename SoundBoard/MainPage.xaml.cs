
using Plugin.Maui.Audio;
namespace SoundBoard;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private async void btnSong1_Clicked(object sender, EventArgs e)
    {
    	var audioPlayer = AudioManager.Current.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("random.wav"));
    	audioPlayer.Play();
    }
    private async void btnSong2_Clicked(object sender, EventArgs e)
   {
       var audioPlayer = AudioManager.Current.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("randomm.wav"));
        audioPlayer.Play();
   }

    private async void btnSong9_Clicked(object sender, EventArgs e)
    {
        var audioPlayer = AudioManager.Current.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("randommm.wav"));
        audioPlayer.Play();
    }

    private async void btnSong8_Clicked(object sender, EventArgs e)
    {
        var audioPlayer = AudioManager.Current.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("meow.wav"));
        audioPlayer.Play();
    }

    private async void btnSong7_Clicked(object sender, EventArgs e)
    {
        var audioPlayer = AudioManager.Current.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("windy-swoosh.wav"));
        audioPlayer.Play();
    }

    private async void btnSong6_Clicked(object sender, EventArgs e)
    {
        var audioPlayer = AudioManager.Current.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("aggressive-beast.wav"));
        audioPlayer.Play();
    }

    private async void btnSong5_Clicked(object sender, EventArgs e)
    {
        var audioPlayer = AudioManager.Current.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("retro-game.wav"));
        audioPlayer.Play();
    }

    private async void btnSong4_Clicked(object sender, EventArgs e)
    {
        var audioPlayer = AudioManager.Current.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("game-over.wav"));
        audioPlayer.Play();
    }

    private async void btnSong3_Clicked(object sender, EventArgs e)
    {
        var audioPlayer = AudioManager.Current.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("randoom.wav"));
        audioPlayer.Play();
    }
}

