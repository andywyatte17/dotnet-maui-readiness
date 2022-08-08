# dotnet-maui-readiness - RESULTS - PHASE1

Here we show how the various features work across the plaforms:

<table>
<tbody>
<!-- U+2713 is a Tick mark -->
<tr>
  <td width="30%">Features</td>
  <td>Windows</td>
  <td>MacCatalyst (MacOS)</td>
  <td>IOS simulator</td>
  <td>Android simulator</td>
</tr>
<tr>
    <td>Button Click Counter</td>
    <td>&#x2713;</td>
    <td>&#x2713;</td>
    <td>&#x2713;</td>
    <td>&#x2713;</td>
</tr>
<tr>
    <td>Nav > Popup</td>
    <td>&#x2713;</td>
    <td>&#x2713;</td>
    <td>&#x2713;</td>
    <td>Popup is too wide in Android - no text wrap.</td>
</tr>
<tr>
    <td>Nav > Page</td>
    <td>&#x2713;</td>
    <td>&#x2713;</td>
    <td>&#x2713;</td>
    <td>&#x2713;</td>
</tr>
<tr>
    <td>File Picker</td>
    <td>&#x2713;</td>
    <td>&#x2713; - see Notes 2.</td>
    <td>&#x2713;</td>
    <td>&#x2713;</td>
</tr>
</tbody>
</table>

## Notes

  1. Nav > Popup - Android - text doesn't wrap.  
     <img src="documentation/images/phase1-android-popup-issue.jpg" />
      - This may be a CommunityToolkit.MAUI issue - let's track  
        <a href="https://github.com/CommunityToolkit/Maui/issues/439">Github > CommunityToolkit.Maui > Issue 439</a>.  
        They say there is might relate to ScrollView usage.
      - See also <a href="https://github.com/CommunityToolkit/Maui/pull/404">CommunityToolkit.Maui &gt; PR 404</a>
          - PR 404 probably doesn't fix this - see it got into the
            <a href="https://github.com/CommunityToolkit/Maui/releases/tag/1.0.0">1.0.0</a> release but we are using 1.2.0.
  2. This failed initially due to Entitlements.plist > sandbox=true settings.
