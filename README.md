# Lista-de-Imagenes
Crear lista de imágenes utilizando el control  GridView


<Page
    x:Class="xBindDataExample.MainPage"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    xmlns:local="using:xBindDataExample"
    xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
    xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
   xmlns:data="using:xBindDataExample.Models"
    mc:Ignorable="d">
    <Page.Resources>
        <DataTemplate x:DataType="data:Book" x:Key="BookDataTemplate">
            <StackPanel HorizontalAlignment="Center">
                <Image Width="150" Source="{x:Bind Imagen}" />
                <TextBlock FontSize="11" Text="{x:Bind Titulo}" HorizontalAlignment="Stretch" />
                <TextBlock FontSize="10" Foreground="Red" Text="{x:Bind Consola}" HorizontalAlignment="Center" />
            </StackPanel>
        </DataTemplate>
    </Page.Resources>
    <Grid Background="{ThemeResource ApplicationPageBackgroundThemeBrush}" Margin="20">
        <Grid.RowDefinitions>
            <RowDefinition Height="*" />
            <RowDefinition Height="100" />
        </Grid.RowDefinitions>

        <GridView ItemsSource="{x:Bind Books}" 
                  IsItemClickEnabled="True" 
                  ItemClick="GridView_ItemClick"
                  ItemTemplate="{StaticResource BookDataTemplate}">
        </GridView>

        <TextBlock Grid.Row="1" 
                   Name="ResultTextBlock" 
                   FontSize="20" 
                   Foreground="Red" 
                   FontWeight="Bold" 
                   Margin="0,20,0,0" />

    </Grid>
</Page>




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
using xBindDataExample.Models;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace xBindDataExample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Book> Books;

        public MainPage()
        {
            this.InitializeComponent();
            Books = BookManager.GetBooks();
        }

        private void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var book = (Book)e.ClickedItem;
            ResultTextBlock.Text = "Usted Seleciono " + book.Titulo; 
        }
    }
}  





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace xBindDataExample.Models
{


    public class Book
    {
     
        public int BookId { get; set; }
        public string Titulo { get; set; }
        public string Consola { get; set; }
        public string Imagen { get; set; }
    }

    public class BookManager
    {
        public static List<Book> GetBooks()
        {
            var books = new List<Book>();

            books.Add(new Book { BookId = 1, Titulo = "RISE OF THE TOMB RAIDER", Consola = "PS4", Imagen = "Assets/1.jpg" });
            books.Add(new Book { BookId = 2, Titulo = "GOD OF WAR III REMASTERED", Consola = "PS4", Imagen = "Assets/2.jpg" });
            books.Add(new Book { BookId = 3, Titulo = "BIOSHOCK THE COLLECTION", Consola = "XBOX ONE", Imagen = "Assets/3.jpg" });
            books.Add(new Book { BookId = 4, Titulo = "GRAND THEFT AUTO V", Consola = "XBOX ONE", Imagen = "Assets/4.jpg" });
            books.Add(new Book { BookId = 5, Titulo = "DONKEY KONG COUNTRY RETURNS", Consola = "WII", Imagen = "Assets/5.jpg" });
            books.Add(new Book { BookId = 6, Titulo = "SUPER MARIO GALAXY 2", Consola = "WII", Imagen = "Assets/6.jpg" });
           

            return books;
        } 
    }
}



