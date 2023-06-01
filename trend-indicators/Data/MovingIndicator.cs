using DevExpress.DashboardCommon;
using DevExpress.DashboardCommon.ViewerData;
using System.Collections.Generic;

namespace asp_net_core_dashboard_control_trendline_indicators.Data {
    public class MovingIndicator : ChartCustomIndicator {
        protected override Dictionary<AxisPoint, object> Calculate(Dictionary<AxisPoint, decimal?> values) {
            var items = new Dictionary<AxisPoint, object>(values.Count);

            var sum = decimal.Zero;
            var count = 0;
            foreach(KeyValuePair<AxisPoint, decimal?> point in values) {
                if(count == 0) {
                    items.Add(point.Key, null);
                } else {
                    items.Add(point.Key, sum / count);
                }
                sum += point.Value ?? 0;
                count++;
            }

            return items;
        }
    }
}
