function registerViewModel() {
	var self = this;

	self.firstName = ko.observable("");
	self.lastName = ko.observable("");
	self.username = ko.observable("");
	self.password = ko.observable("");
	self.repeatPassword = ko.observable("");

	self.registerUser = function () {
		$.ajax({
			url: "/RegisterAPI/RegisterUser",
			type: "PUT",
			data: {
				firstName: self.firstName(),
				lastName: self.lastName(),
				username: self.username(),
				password: self.password()
			},
			success: function (result) {
				console.log("Got: " + result);
				//window.location.href = '/Home/Index'; //Go to the Home page.
			}
		});
	};
}

ko.applyBindings(registerViewModel);