using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Microsoft.Graphics.Canvas.UI.Xaml;
using Microsoft.Graphics.Canvas.UI;
using Windows.UI;
using Windows.UI.Core;
using Windows.Media.Playback;
using Windows.Media.Core;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409
//sources: https://github.com/EricCharnesky/CIS297-Winter2020/tree/master/PongExample/PongExample
namespace UWP_Tetris
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Tetris tetris;
        MediaPlayer player;
        public MainPage()
        {
            this.InitializeComponent();
            tetris = new Tetris();
            //player = new MediaPlayer();
            //playmusic(player);
            createPiece();
            Window.Current.CoreWindow.KeyDown += canvasKeyDown;
        }
        //mediaplayer code taken from https://www.youtube.com/watch?v=hPxExtLCMK0
        //song is The Swords of Ditto theme song edited for looping
        //poorly edited by Dana *waves hand*
        private async void playmusic(MediaPlayer player)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("swordsofdittoloopish.mp3");
            player.Source = MediaSource.CreateFromStorageFile(file);
            player.Play();
            player.IsLoopingEnabled = true;
        }
        private void canvasKeyDown(CoreWindow sender, KeyEventArgs args)
        {
            if(args.VirtualKey == Windows.System.VirtualKey.Left)
            {
                tetris.MoveTetrisPiece(-20);
            }
            else if(args.VirtualKey == Windows.System.VirtualKey.Right)
            {
                tetris.MoveTetrisPiece(20);
            }
            else if (args.VirtualKey == Windows.System.VirtualKey.Space)
            {
                tetris.RotateTetrisPiece();
            }
        }

        private void createPiece()
        {
            tetris.setPiece();
        }

        private void Canvas_CreateResources(CanvasAnimatedControl sender, CanvasCreateResourcesEventArgs args)
        {
            
        }

        private void Canvas_Draw(ICanvasAnimatedControl sender, CanvasAnimatedDrawEventArgs args)
        {
            tetris.DrawPiece(args.DrawingSession);
            tetris.drawScreen(args.DrawingSession);
        }

        private void Canvas_Update(ICanvasAnimatedControl sender, CanvasAnimatedUpdateEventArgs args)
        {

        }
    }
}
