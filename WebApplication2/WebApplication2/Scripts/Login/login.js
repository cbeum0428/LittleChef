function loginViewModel() {
	var self = this;

	self.username = ko.observable("");
	self.password = ko.observable("");

	self.login = function () {
		$.ajax({
			url: "/LoginAPI/VerifyCredentials",
			type: "GET",
			data: {
				username: self.username(),
				password: self.password()
			},
			success: function (result) {
				console.log("Got: " + result);
				//window.location.href = '/Home/Index'; //Go to the Home page.
			}
		});
	};

	self.register = function () {
		window.location.href = "/Register/Register";
	};
}

ko.applyBindings(loginViewModel);