(function() {
	
	// Listen to game
	window.addEventListener("message", function(event) {
		
		var name = "MyResourceName";
		var action = event.data.action;
		var data = event.data.data;
		
		var ignoreActions = [];
		if (!ignoreActions.includes(action))
			console.log(name + " received message from game: ", action, data);
		
		switch(action) {
			case "MyAction":
				MyAction(data);
				break;
		}
		
	});
	
	function ui() {
		return $("ui");
	}
	
	/*
	    _   ___ _____ ___ ___  _  _ ___ 
	   /_\ / __|_   _|_ _/ _ \| \| / __|
	  / _ \ (__  | |  | | (_) | .` \__ \
	 /_/ \_\___| |_| |___\___/|_|\_|___/
	 
	*/
	
	function MyAction(data) {
		var ui = ui();
		ui.html(data);
	}
	
})();