# .NET MAUI Readiness Project

This is a project to test whether .NET MAUI is ready, where ready is defined as:

  - The project has some required features.
  - The project is buildable for all platforms.
  - All features work as expected on all platforms.

## Required Features

Below is a list of features we expect. This list may grow as
time goes on.

Feature list:

  - Prism for features such as
      - Navigation
      - ...
  - SKCanvasView
  - Open and display contents of binary file from the platform
  - Use MVVM model for backwards compatibility.
  - Popup modals - maybe RgPopup.

## Platforms

We require that the project builds and runs on:

  - Android
  - IOS
  - Windows (not UWP)
  - MacOS (Mac Catalyst)
  - FUTURE? Mac (non-Catalyst)

<hr/>

# Work Phases

## PHASE1

This is the first batch of work that occurred around August 2022. This involves making
a test application with Windows as the dev platform with a number of features for testing.

The method and details are found in [PHASE1.md](PHASE1.md).

## PHASE1a

Test the work in Phase 1 on various non-Windows platforms, including coming up with a
build process.

The method and details are found in [PHASE1a.md](PHASE1a.md).
