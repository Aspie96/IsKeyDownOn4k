# IsKeyDownOn4k
This sample shows how, in Windows 10, if you call [`Keyboard.IsKeyDown`](https://msdn.microsoft.com/it-it/library/system.windows.input.keyboard.iskeydown(v=vs.110).aspx) in the [`Form.Load`](https://msdn.microsoft.com/it-it/library/system.windows.forms.form.load(v=vs.110).aspx) event, on a 4K screen, the window size will be smaller than it is supposed to (depending on user settings, applications on UHD displays must be scaled, usually at 250%).

Although it's not really a problem at all, in most cases (there are not many reasons to call `Keyboard.IsKeyDown` anyways), it might reveal some imperfection that would be great to fix, in order to prevent side effects.

## The issue on Developer Community
You can see a discussion about this issue [here](https://developercommunity.visualstudio.com/content/problem/50114/keyboardiskeydown-on-4k-screen.html).
