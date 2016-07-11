# Ecclesion OHP

Open Source projection software for the Church

## Engineering Notes

		[GUI] Keys/Clicks - intent to advance slide or end show
		  |
		  |  Fires method of
		  V
		[DisplayController]
		  |
		  |	 Raises event like Update or CloseDisplay
		  V
		[DisplayScreen] Handles events

Anything which shows slides, such as the DisplayScreen, holds and instance of `DisplayController`. The DisplayController has events such as Update and CloseDisplay. A screen handles those events.

The GUI used by the operator calls methods of the DisplayController in order to change what's on screen