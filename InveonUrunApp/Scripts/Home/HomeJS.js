var app = angular.module('app', []);


app.controller('HomeCtrl', function ($scope, $filter, $http, $window) {
    $scope.Load = function () {
        $scope.productShow = true;
        $scope.productListShow = true;
        productList();
        $scope.AdminCheck();
    }


    var productList = function () {

        $http.get('/Default/GetProductList').then(
            function mySuccess(response) {

                $scope.productList = response.data;
                for (var i = 0; i < $scope.productList.length; i++) {
                    $scope.productList[i].CreateDate = moment($scope.productList[i].CreateDate).format('DD/MM/YYYY');
                }
            },
            function myError(response) {
            });
    }

    $scope.AdminCheck = function () {
        $http.get('/Default/AdminCheck').then(
            function mySuccess(response) {
                $scope.isAdmin = response.data.Success;
            },
            function myError(response) {
                $scope.isAdmin = false;

            });
    };

    $scope.MenuClick = function (data) {
        if (data == 0) {
            $scope.productShow = true;
            $scope.managementShow = false;
        }
        else {
            $scope.productShow = false;
            $scope.managementShow = true;
        }
    };

    $scope.GetProduct = function (data) {
        $http.get('/Default/GetProductDetail?Id=' + data).then(
            function mySuccess(response) {
                $scope.product = response.data;
                $scope.productListShow = false;
                $scope.updateShow = true;
            },
            function myError(response) {
                $scope.Mesaj = response.data;
            });
    }

    $scope.updateBackClick = function () {
        $scope.productListShow = true;
        $scope.insertShow = false;
        $scope.updateShow = false;
    };

    $scope.productInsert = function (data) {
        var parametre = {
            ProductName: data.ProductName,
            Description: data.Description,
            Barcode: data.Barcode,
            Price: data.Price,
            Image: data.Image,
            Quantity: data.Quantity
        };
        $http.post('/Default/InsertProductDetail', parametre).then(
            function mySuccess(response) {
                if (response.data.Success) {
                    $scope.updateBackClick();
                    productList();
                }
            },
            function myError(response) {
            });
    }

    $scope.insertProductClick = function () {
        $scope.product = null;
        $scope.insertShow = true;
        $scope.updateShow = false;
        $scope.productListShow = false;
    }

    $scope.productUpdate = function (data) {
        var parametre = {
            Id: data.Id,
            ProductName: data.ProductName,
            Description: data.Description,
            Barcode: data.Barcode,
            Price: data.Price,
            Image: data.Image,
            Quantity: data.Quantity
        };
        $http.post('/Default/UpdateProductDetail', parametre).then(
            function mySuccess(response) {
                if (response.data.Success) {
                    $scope.updateBackClick();
                    productList();
                }
            },
            function myError(response) {
            });
    }

    $scope.deleteProduct = function (data) {
        $http.get('/Default/DeleteProduct?Id=' + data).then(
            function mySuccess(response) {
                $scope.updateBackClick();
                productList();
            },
            function myError(response) {
            });
    }

    $scope.ExitBtnClick = function () {
        $window.location.href = $window.location.origin + '/Login/Login';
    }
});