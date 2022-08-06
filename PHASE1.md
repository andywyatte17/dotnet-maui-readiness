# dotnet-maui-readiness - phase 1

## References

  - ms-dotnet-first-app
      - Instructions as per 
        [Microsoft dotnet maui first-app](https://docs.microsoft.com/en-us/dotnet/maui/get-started/first-app?pivots=devices-windows).

<hr/>

## Environment

  - Windows 10
  - Visual Studio 2022 Preview for Windows
     - 17.3.0 Preview 5

## Making the first-app

  - From VS2022 New Template
      - .NET MAUI App
      - Project Name *NetMauiReadiness*
      - Framework .NET 6.0 (Long-term support)

## Nuget packages (part 1)

  - Add Prism.Core
  - Add Prism.Maui
  - Add Prism.DryIoc.Maui

<hr/>

## Feature progress

### Added MainPageViewModel etc...

  - Added ViewModelBase(.cs)
  - Added MainViewModel(.cs) derived from ViewModelBase.
  - Made MainPage's view-model MainViewModel.
  - Bound new Button 'Show Popup' to ICommand MainViewModel.ShowPopup.

### ShowPopup