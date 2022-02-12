var app = angular.module('app', []);


app.controller('LoginCtrl', function ($scope, $filter, $http,$window) {
  

    $scope.LoginCheck = function () {
        var parametre = {
            UserName: $scope.userName,
            Password: $scope.password
        };
        $http.post('/Login/LoginCheck', parametre).then(
            function mySuccess(response) {
                if (response.data.Success == false) {
                    $scope.ErrorMessage = 'Kullanıcı bulunamadı.';
                }
                else {

                    $window.location.href = $window.location.origin + '/Default/Home';

                }

            },
            function myError(response) {
                $("#messageModal").modal('show');
            });
    }
});