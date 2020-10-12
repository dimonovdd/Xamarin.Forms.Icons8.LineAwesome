# Xamarin.Forms.Icons8.LineAwesome
**Nuget package coming soon**

Implementation [Icons8 LineAwesome](https://github.com/icons8/line-awesome) For Xamarin.Forms

### Sample

```
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:icons="clr-namespace:Icons8;assembly=Icons8.LineAwesome"
             x:Class="LineAwesome.Sample.MainPage"
             BackgroundColor="White">

    <StackLayout HorizontalOptions="FillAndExpand" VerticalOptions="FillAndExpand">
        <Image Margin="15" HorizontalOptions="Center" VerticalOptions="Center">
            <Image.Source>
                <icons:LineAwesomeSource Icon="Github" IconType="Brand" Color="Black" Size="400" />
            </Image.Source>
        </Image>
        <Image Margin="15" HorizontalOptions="Center" VerticalOptions="Center">
            <Image.Source>
                <icons:LineAwesomeSource Icon="Heart" IconType="Regular" Color="Red" Size="400" />
            </Image.Source>
        </Image>
    </StackLayout>
</ContentPage>
```
<img src="/SampleImages/sample.jpg" width="177" height="384"/>
