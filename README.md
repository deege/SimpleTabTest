# UnityUITabTest

Project demonstrating mismatch between using keyboard and controller. This control/visual element layout matches closely to a header, button region, child controls, and then a footer button.

To demonstrate

1. Tab through controls using keyboard. The order should be button 1, button 2, slider 1, slider 2, slider 3, toggle, button 3.
2. Use controller to navigate controls. The order is not repeated, and difficult to move around. When updating the slider values, the focus bounces between the button immediately to the right and then back to the slider. Some cases will bounce to a different slider.
