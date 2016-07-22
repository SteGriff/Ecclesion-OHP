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

## Visual Standards

### Buttons

 * Always 31px tall unless they have a reason to be bigger
 * Segoe UI, 11.25pt
 
### Labels

 * Segoe UI, 12pt
 

## Message-passing

 * A service used within the application which can have different results should return an `Ecclesion.OHP.Core.Enums.ActionResult` (enum)
 * Although this enum contains a `Failed` member, we prefer to throw an appropriate Exception.
 * Exceptions should be caught as high up as possible, rather than being handled or transformed in middle layers.
 
