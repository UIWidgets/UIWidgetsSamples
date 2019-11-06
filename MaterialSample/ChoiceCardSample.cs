using System.Linq;
using Unity.UIWidgets.material;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;
using UnityEngine;

namespace UIWidgetsSample {
    
    public class ChoiceCardSample : UIWidgetsSamplePanel {

        protected override Widget createWidget() {
            return new MaterialApp(
                showPerformanceOverlay: false,
                home: new ListView(
                    children: Choice.choices.Select<Choice, Widget> (choice => new ChoiceCard(choice: choice)).ToList()));
        }

        protected override void OnEnable() {
            FontManager.instance.addFont(Resources.Load<Font>(path: "fonts/MaterialIcons-Regular"), "Material Icons");
            base.OnEnable();
        }
    }
    

}