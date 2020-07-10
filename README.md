# XAMLDesignTimeSamples

Demo app the showcase the capabilites of design-time data for .NET desktop applcations powered by XAML (WPF .NET Core & UWP). 

**Getting Started:**

* This feature was first introduced in Visual Studio 2019 16.7 Preview 3. While in preview you might have to turn the feature on in settings even if you have the preview installed ( “Options > Environment > Preview Features” and enable “Expanded Design-time Data Support”)

**Known Issues/limitations:**

* **UserControls hosted in parent page don't render d:**: UserControls can be created and visualized using design-time data, but when hosted in a parent page the design-time data using d: won't be a consistent experience and likely not show up. We're working to improve this experience in 16.8 timeframe.

**Resources:**
* You can see a demo of this feature from our [June 2019 .NET Desktop Community Standup (starting at 29 minutes)](https://youtu.be/q7ODj3RJnME?t=1765)
