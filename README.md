# Xamarin.Forms.Icons8.LineAwesome <img src="/icon.png" width="45" height="40"/>

This package is a simple implementation of the beautiful Icons Font ["Icons8 LineAwesome"](https://icons8.com/line-awesome) For Xamarin.Forms [*(Screenshot)*](https://raw.githubusercontent.com/dimonovdd/Xamarin.Forms.Icons8.LineAwesome/main/SampleImages/sample.jpg)

| Font    | Nuget         |
|:--------|:-------------:|
| Solid   | [![NuGet](https://img.shields.io/nuget/v/Xamarin.Forms.Icons8.LineAwesome.Solid?style=plastic)](https://www.nuget.org/packages/Xamarin.Forms.Icons8.LineAwesome.Solid/)    |
| Regular | [![NuGet](https://img.shields.io/nuget/v/Xamarin.Forms.Icons8.LineAwesome.Regular?style=plastic)](https://www.nuget.org/packages/Xamarin.Forms.Icons8.LineAwesome.Regular/)|
| Brand   | [![NuGet](https://img.shields.io/nuget/v/Xamarin.Forms.Icons8.LineAwesome.Brand?style=plastic)](https://www.nuget.org/packages/Xamarin.Forms.Icons8.LineAwesome.Brand/)    | 

This package is divided into three nugets, so you don't install fonts that you don't use

Icon naming differs from icons8 according to the C# language rules.

| icons8         | icons8 HTML       | this project  |
|:--------------:|:-----------------:|:-------------:|
|dog             |la-dog             |Dog            |
|question-circle |la-question-circle |QuestionCircle |
|500px           |la-500px           |_500x          |

#### Littel Sample:
```xml
xmlns:iconsB="clr-namespace:Icons8.LineAwesome.Brand;assembly=Icons8.LineAwesome.Brand"
```
```xml
<Image>
    <Image.Source>
        <iconsB:IconSource Icon="Github" Size="100" Color="Red"/>
    </Image.Source>
</Image>
```
[***See more...***](https://github.com/dimonovdd/Xamarin.Forms.Icons8.LineAwesome/blob/main/src/LineAwesome.Sample/LineAwesome.Sample/MainPage.xaml)
