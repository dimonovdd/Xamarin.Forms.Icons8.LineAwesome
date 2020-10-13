# Xamarin.Forms.Icons8.LineAwesome
**[Nuget package](https://www.nuget.org/packages/Xamarin.Forms.Icons8.LineAwesome/)**

Implementation [Icons8 LineAwesome](https://github.com/icons8/line-awesome) For Xamarin.Forms

### Sample

```
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:icons="clr-namespace:Icons8.LineAwesome;assembly=Icons8.LineAwesome"
             x:Class="LineAwesome.Sample.MainPage"
             BackgroundColor="White">
    <ContentPage.Resources>
        <ResourceDictionary>
            <icons:IconToStringConverter x:Key="iconConv" />
        </ResourceDictionary>
    </ContentPage.Resources>

    <StackLayout HorizontalOptions="FillAndExpand" VerticalOptions="FillAndExpand">
        <Image Margin="15" HorizontalOptions="Center" VerticalOptions="Center">
            <Image.Source>
                <icons:IconSolidSource Icon="Heart" Size="100" />
            </Image.Source>
        </Image>

        <Image Margin="15" HorizontalOptions="Center" VerticalOptions="Center">
            <Image.Source>
                <icons:IconRegularSource Icon="Heart" Color="Red" Size="100"/>
            </Image.Source>
        </Image>

        <Image Margin="15" HorizontalOptions="Center" VerticalOptions="Center">
            <Image.Source>
                <icons:IconBrandSource Icon="Github" Size="100"/>
            </Image.Source>
        </Image>

        <Image Margin="15" HorizontalOptions="Center" VerticalOptions="Center">
            <Image.Source>
                <FontImageSource 
                        Glyph="{Binding Source={x:Static icons:IconBrand.Git}, Converter={StaticResource iconConv}}"
                        FontFamily="{x:Static icons:LineAwesomeFont.brand}" Color="Blue" Size="100"/>
            </Image.Source>
        </Image>

        <Label Margin="15" HorizontalOptions="Center" VerticalOptions="Center" FontSize="100" TextColor="Green"
                Text="{Binding Source={x:Static icons:IconRegular.Smile}, Converter={StaticResource iconConv}}" 
                FontFamily="{x:Static icons:LineAwesomeFont.regular}"/>
    </StackLayout>
</ContentPage>
```
<img src="/SampleImages/sample.jpg" width="177" height="384"/>
