/*
 * ATTENTION: The "eval" devtool has been used (maybe by default in mode: "development").
 * This devtool is neither made for production nor for readable output files.
 * It uses "eval()" calls to create a separate source file in the browser devtools.
 * If you are trying to read the output file, select a different devtool (https://webpack.js.org/configuration/devtool/)
 * or disable the default devtool with "devtool: false".
 * If you are looking for production-ready output files, see mode: "production" (https://webpack.js.org/configuration/mode/).
 */
/******/ (() => { // webpackBootstrap
/******/ 	"use strict";
/******/ 	var __webpack_modules__ = ({

/***/ "./src/home/home.ts":
/*!**************************!*\
  !*** ./src/home/home.ts ***!
  \**************************/
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

eval("\r\n//@ts-nocheck\r\nObject.defineProperty(exports, \"__esModule\", ({ value: true }));\r\nvar axios_1 = __webpack_require__(/*! ../package/axios */ \"./src/package/axios/index.ts\");\r\nvar routes_1 = __webpack_require__(/*! ../package/axios/routes */ \"./src/package/axios/routes.ts\");\r\nvar store = document.getElementById(\"store\");\r\nvar btnList = store === null || store === void 0 ? void 0 : store.querySelectorAll('button[type=\"button\"]');\r\nvar total = 0;\r\nvar update = function (data) {\r\n    var wrapper = document.createElement(\"div\");\r\n    total = 0;\r\n    data.forEach(function (item) {\r\n        var element = createEntity(item.name, item.quantity, item.retailPrice, item.productId);\r\n        wrapper.appendChild(element);\r\n    });\r\n    var cart = document.getElementById(\"cart\");\r\n    if (cart) {\r\n        var totalElement = createEntity(\"Total\", 1, total, \"total\");\r\n        cart.innerHTML = \"\";\r\n        cart.appendChild(wrapper);\r\n        cart.appendChild(totalElement);\r\n    }\r\n};\r\nvar createEntity = function (name, quantity, price, id) {\r\n    var plus = document.createElement(\"div\");\r\n    var minus = document.createElement(\"div\");\r\n    plus.classList.add(\"p-1\", \"font-semibold\");\r\n    minus.classList.add(\"p-1\", \"font-semibold\");\r\n    plus.innerHTML = \"+\";\r\n    minus.innerHTML = \"-\";\r\n    plus.addEventListener(\"click\", function () {\r\n        axios_1.http.post(routes_1.routers.order.addToCart, { productId: id, quantity: 1 }).then(function (res) {\r\n            update(res.data.data);\r\n        });\r\n    });\r\n    minus.addEventListener(\"click\", function () {\r\n        axios_1.http.post(routes_1.routers.order.addToCart, { productId: id, quantity: -1 }).then(function (res) {\r\n            update(res.data.data);\r\n        });\r\n    });\r\n    total += quantity * price;\r\n    var wrapper = document.createElement(\"div\");\r\n    wrapper.classList.add(\"flex\", \"items-center\", \"block\", \"p-3\", \"transition\", \"duration-300\", \"ease-in-out\", \"bg-white\", \"rounded-md\", \"cursor-pointer\", \"dark:bg-dark-3\", \"hover:bg-gray-200\", \"dark:hover:bg-dark-1\");\r\n    var top = document.createElement(\"div\");\r\n    top.classList.add(\"w-3/6\", \"mr-1\", \"truncate\", \"pos__ticket__item-name\");\r\n    top.innerHTML = name;\r\n    var bottom = document.createElement(\"div\");\r\n    bottom.classList.add(\"w-1/6\", \"ml-auto\", \"font-medium\");\r\n    bottom.innerHTML = \"$\" + price * quantity;\r\n    var label = document.createElement(\"div\");\r\n    var buttonWrapper = document.createElement(\"div\");\r\n    buttonWrapper.classList.add(\"flex\", \"items-center\", \"w-1/6\", \"space-x-2\", \"add-cart\");\r\n    if (id !== \"total\") {\r\n        buttonWrapper.appendChild(plus);\r\n        buttonWrapper.appendChild(label);\r\n        buttonWrapper.appendChild(minus);\r\n    }\r\n    label.classList.add(\"text-gray-600\");\r\n    label.innerHTML = \"\" + quantity;\r\n    wrapper.append(top);\r\n    wrapper.append(buttonWrapper);\r\n    wrapper.append(bottom);\r\n    return wrapper;\r\n};\r\naxios_1.http.get(routes_1.routers.order.getCart).then(function (res) {\r\n    update(res.data.data);\r\n});\r\nbtnList === null || btnList === void 0 ? void 0 : btnList.forEach(function (btn) {\r\n    btn.addEventListener(\"click\", function (event) {\r\n        var id = btn.getAttribute(\"data-id\") || \"\";\r\n        axios_1.http.post(routes_1.routers.order.addToCart, { productId: id, quantity: 1 }).then(function (res) {\r\n            update(res.data.data);\r\n        });\r\n    });\r\n});\r\nvar payment = 0;\r\nvar paymentList = document.querySelectorAll('input[name=\"payment\"]');\r\npaymentList.forEach(function (radio) {\r\n    radio.addEventListener(\"click\", function () {\r\n        payment = Number(radio.value);\r\n    });\r\n});\r\nvar order = document.getElementById(\"order\");\r\norder === null || order === void 0 ? void 0 : order.addEventListener(\"submit\", function (event) {\r\n    event.preventDefault();\r\n    axios_1.http.post(routes_1.routers.order.create, { paymentMethod: payment }).then(function () {\r\n        window.location.reload();\r\n    });\r\n});\r\n\n\n//# sourceURL=webpack://mono-webpack/./src/home/home.ts?");

/***/ }),

/***/ "./src/package/axios/index.ts":
/*!************************************!*\
  !*** ./src/package/axios/index.ts ***!
  \************************************/
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

eval("\r\nObject.defineProperty(exports, \"__esModule\", ({ value: true }));\r\nexports.http = void 0;\r\nvar interceptor_1 = __webpack_require__(/*! ./interceptor */ \"./src/package/axios/interceptor.ts\");\r\nvar http = axios;\r\nexports.http = http;\r\nhttp.defaults.withCredentials = true;\r\nhttp.interceptors.request.use(interceptor_1.requestInterceptor);\r\nhttp.interceptors.response.use(interceptor_1.responseSuccessInterceptor, interceptor_1.responseFailedInterceptor);\r\n\n\n//# sourceURL=webpack://mono-webpack/./src/package/axios/index.ts?");

/***/ }),

/***/ "./src/package/axios/interceptor.ts":
/*!******************************************!*\
  !*** ./src/package/axios/interceptor.ts ***!
  \******************************************/
/***/ ((__unused_webpack_module, exports) => {

eval("\r\nObject.defineProperty(exports, \"__esModule\", ({ value: true }));\r\nexports.responseFailedInterceptor = exports.responseSuccessInterceptor = exports.handleCommonResponse = exports.requestInterceptor = void 0;\r\nfunction requestInterceptor(req) {\r\n    var btn = document.getElementById(\"form-btn\");\r\n    var loading = document.getElementById(\"loading\");\r\n    var message = document.getElementById(\"message\");\r\n    var errorMessage = document.getElementById(\"errorMessage\");\r\n    for (var key in req.data) {\r\n        var error = document.getElementById(key.toUpperCase() + \"ERROR\");\r\n        if (error) {\r\n            error.innerHTML = \"\";\r\n        }\r\n    }\r\n    if (errorMessage) {\r\n        errorMessage.innerHTML = \"\";\r\n    }\r\n    if (message) {\r\n        message.innerHTML = \"\";\r\n    }\r\n    if (loading && btn) {\r\n        btn.classList.add(\"hidden\");\r\n        loading.classList.remove(\"hidden\");\r\n        loading.classList.add(\"flex\");\r\n    }\r\n    return req;\r\n}\r\nexports.requestInterceptor = requestInterceptor;\r\nfunction handleCommonResponse() {\r\n    var btn = document.getElementById(\"form-btn\");\r\n    var loading = document.getElementById(\"loading\");\r\n    if (loading && btn) {\r\n        btn.classList.remove(\"hidden\");\r\n        btn.classList.add(\"block\");\r\n        loading.classList.add(\"hidden\");\r\n        loading.classList.remove(\"flex\");\r\n    }\r\n}\r\nexports.handleCommonResponse = handleCommonResponse;\r\nfunction responseSuccessInterceptor(response) {\r\n    var _a, _b, _c, _d;\r\n    handleCommonResponse();\r\n    if ((_b = (_a = response === null || response === void 0 ? void 0 : response.data) === null || _a === void 0 ? void 0 : _a.details) === null || _b === void 0 ? void 0 : _b.message) {\r\n        var message = document.getElementById(\"MESSAGEERROR\");\r\n        if (message) {\r\n            message.innerHTML = (_d = (_c = response === null || response === void 0 ? void 0 : response.data) === null || _c === void 0 ? void 0 : _c.details) === null || _d === void 0 ? void 0 : _d.message;\r\n        }\r\n    }\r\n    return response;\r\n}\r\nexports.responseSuccessInterceptor = responseSuccessInterceptor;\r\nfunction responseFailedInterceptor(error) {\r\n    var _a, _b;\r\n    handleCommonResponse();\r\n    if ((_b = (_a = error.response) === null || _a === void 0 ? void 0 : _a.data) === null || _b === void 0 ? void 0 : _b.details) {\r\n        var details = error.response.data.details;\r\n        for (var key in details) {\r\n            var error_1 = document.getElementById(key.toUpperCase() + \"ERROR\");\r\n            if (error_1) {\r\n                error_1.innerHTML = error_1.getAttribute(\"data-label\") + \" \" + details[key];\r\n            }\r\n            if (error_1 && (key === \"errorMessage\" || key === \"message\")) {\r\n                error_1.innerHTML = \"\" + details[key];\r\n            }\r\n        }\r\n    }\r\n    return Promise.reject(error.response);\r\n}\r\nexports.responseFailedInterceptor = responseFailedInterceptor;\r\n\n\n//# sourceURL=webpack://mono-webpack/./src/package/axios/interceptor.ts?");

/***/ }),

/***/ "./src/package/axios/routes.ts":
/*!*************************************!*\
  !*** ./src/package/axios/routes.ts ***!
  \*************************************/
/***/ ((__unused_webpack_module, exports) => {

eval("\r\nObject.defineProperty(exports, \"__esModule\", ({ value: true }));\r\nexports.routers = exports.routerLinks = void 0;\r\nexports.routerLinks = {\r\n    home: \"/\",\r\n    loginForm: \"/auth/login\",\r\n};\r\nexports.routers = {\r\n    category: {\r\n        create: \"/api/category\",\r\n        update: \"/api/category\",\r\n    },\r\n    order: {\r\n        addToCart: \"/api/cart/add\",\r\n        getCart: \"/api/cart\",\r\n        create: \"/api/order\",\r\n    },\r\n    user: {\r\n        changePassword: \"/api/user/password\",\r\n        update: \"/api/user\",\r\n        login: \"/api/auth/login\",\r\n        register: \"/api/auth/register\",\r\n    },\r\n    product: {\r\n        create: \"/api/product\",\r\n        update: \"/api/product\",\r\n    },\r\n};\r\n\n\n//# sourceURL=webpack://mono-webpack/./src/package/axios/routes.ts?");

/***/ })

/******/ 	});
/************************************************************************/
/******/ 	// The module cache
/******/ 	var __webpack_module_cache__ = {};
/******/ 	
/******/ 	// The require function
/******/ 	function __webpack_require__(moduleId) {
/******/ 		// Check if module is in cache
/******/ 		var cachedModule = __webpack_module_cache__[moduleId];
/******/ 		if (cachedModule !== undefined) {
/******/ 			return cachedModule.exports;
/******/ 		}
/******/ 		// Create a new module (and put it into the cache)
/******/ 		var module = __webpack_module_cache__[moduleId] = {
/******/ 			// no module.id needed
/******/ 			// no module.loaded needed
/******/ 			exports: {}
/******/ 		};
/******/ 	
/******/ 		// Execute the module function
/******/ 		__webpack_modules__[moduleId](module, module.exports, __webpack_require__);
/******/ 	
/******/ 		// Return the exports of the module
/******/ 		return module.exports;
/******/ 	}
/******/ 	
/************************************************************************/
/******/ 	
/******/ 	// startup
/******/ 	// Load entry module and return exports
/******/ 	// This entry module can't be inlined because the eval devtool is used.
/******/ 	var __webpack_exports__ = __webpack_require__("./src/home/home.ts");
/******/ 	
/******/ })()
;