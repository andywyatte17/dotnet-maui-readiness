# dotnet-maui-readiness - PHASE1a

## References

  - ms-build-ios-on-macos-cli
      - Instructions as per 
        [Build an iOS app with .NET CLI](https://docs.microsoft.com/en-us/dotnet/maui/ios/cli).

<hr/>

## Build on MacOS for IOS

### MacOS Environment

  - MacMini x86-64
  - MacOS Monterey 12.4
  - Xcode 13.3.1
  - .NET 6.0 set up using CLI with .NET MAUI workload
      - See *ms-build-ios-on-macos-cli*

### MacOS Build Commands (for IOS)

  - Build app using the command adapted from
*ms-build-ios-on-macos-cli*:
```sh
dotnet build -f net6.0-ios
# dotnet build -t:Run -f net6.0-ios << should work but didn't
```
  - Drag-drop app bundle on to simulator.

<hr/>

## Build on MacOS for MacCatalyst

### MacOS Environment

  - MacMini x86-64
  - MacOS Monterey 12.4
  - Xcode 13.3.1
  - .NET 6.0 set up using CLI with .NET MAUI workload
      - See *ms-build-ios-on-macos-cli*

### MacOS Build Commands (for MacCatalyst)

  - Build app using the command adapted from
*ms-build-ios-on-macos-cli*:
```sh
dotnet build -t:Run -f net6.0-maccatalyst
```
  - Drag-drop app bundle on to simulator.

