<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/648248707/2023.1)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1169490)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Dashboard for ASP.NET Core - Custom Trend Indicator

The following example shows how to create a custom “Moving Average” indicator:

![Moving Average Indicator](Images/chart.png)

1. Create a [ChartCustomIndicator](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.ChartCustomIndicator) descendant (the `MovingIndicator` class in this example). `MovingIndicator` accepts a collection of data points, evaluates the values, and returns the resulting points. These points are used to draw the indicator.

2. Register the `MovingIndicator` type in [IndicatorFactory](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.IndicatorFactory) to make this type available as an indicator type. Call the [Register](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.IndicatorFactory.Register--1(System.String)) method in your application before you save and load a dashboard to serialize and deserialize the indicator within the dashboard XML.

4. Register [ChartIndicatorsExtension](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.Designer.ChartIndicatorsExtension) before the control is rendered to add the `MovingIndicator` type to the Trend Indicators editor.

3. Create an instance of `MovingIndicator` and specify indicator settings.

4. After you launch the application, open the Trend Indicators editor and add a new trend indicator of the "Moving Average" type. 

## Files to Review

- [Program.cs](./trend-indicators/Program.cs) 
- [MovingIndicator.cs](./trend-indicators/Data/MovingIndicator.cs) 
- [_Layout.cshtml](./trend-indicators/Pages/_Layout.cshtml)                               

## Documentation

- [Trend Indicators](https://docs.devexpress.com/Dashboard/404416/web-dashboard/create-dashboards-on-the-web/dashboard-item-settings/chart/trend-indicators?v=23.1)
