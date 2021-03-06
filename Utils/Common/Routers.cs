namespace Backend.Utils.Common
{

    public class RouterItem
    {
        public string Title;
        public string Page;
        public string Link;
    }
    public class Routers
    {

        //Auth Controller
        public static readonly RouterItem Register = new RouterItem() { Page = "/Views/Containers/Auth/Register.cshtml", Title = "Register", Link = "/auth/register" };
        public static readonly RouterItem Login = new RouterItem() { Page = "/Views/Containers/Auth/Login.cshtml", Title = "Login", Link = "/auth/login" };

        //User Controller
        public static readonly RouterItem User = new RouterItem() { Page = "/Views/Containers/User/User.cshtml", Title = "User", Link = "/user" };
        public static readonly RouterItem UpdatePassword = new RouterItem() { Page = "/Views/Containers/User/UpdatePassword.cshtml", Title = "Update Password", Link = "/user/password" };
        public static readonly RouterItem UpdateUserInfo = new RouterItem() { Page = "/Views/Containers/User/UpdateUserInfo.cshtml", Title = "Update User Info", Link = "/user/info" };
        //------------------------------------
        public static readonly RouterItem Home = new RouterItem() { Page = "/Views/Containers/Home.cshtml", Title = "Home", Link = "/" };
        public static readonly RouterItem Category = new RouterItem() { Page = "/Views/Containers/Category/Category.cshtml", Title = "All Category", Link = "/category" };
        public static readonly RouterItem CreateCategory = new RouterItem() { Page = "/Views/Containers/Category/CreateCategory.cshtml", Title = "Create Category", Link = "/category/create" };
        public static readonly RouterItem UpdateCategory = new RouterItem() { Page = "/Views/Containers/Category/UpdateCategory.cshtml", Title = "Update Category", Link = "/category/update" };
        public static readonly RouterItem DeleteCategory = new RouterItem() { Page = "/Views/Containers/DeleteCategory.cshtml", Title = "Delete Category", Link = "/category/delete" };
        public static readonly RouterItem Product = new RouterItem() { Page = "/Views/Containers/Product/Product.cshtml", Title = "All Product", Link = "/product" };
        public static readonly RouterItem CreateProduct = new RouterItem() { Page = "/Views/Containers/Product/CreateProduct.cshtml", Title = "Create Product", Link = "/product/create" };
        public static readonly RouterItem UpdateProduct = new RouterItem() { Page = "/Views/Containers/Product/UpdateProduct.cshtml", Title = "Update Product", Link = "/product/update" };
        public static readonly RouterItem Logout = new RouterItem() { Page = "/Views/Containers/CreateProduct.cshtml", Title = "Create Product", Link = "/auth/logout" };
        public static readonly RouterItem Order = new RouterItem() { Page = "/Views/Containers/order/Order.cshtml", Title = "Your Order", Link = "/order" };
        public static readonly RouterItem OrderDetail = new RouterItem() { Page = "/Views/Containers/order/OrderDetail.cshtml", Title = "Order Detail", Link = "/order/detail" };
        public static readonly RouterItem Manager = new RouterItem() { Page = "/Views/Containers/order/Manager.cshtml", Title = "Users Order", Link = "/order/manager" };
        public static readonly RouterItem SearchOrders = new RouterItem() { Page = "/Views/Containers/order/Manager.cshtml", Title = "Users Order", Link = "/order/search" };
        public static readonly RouterItem Cart = new RouterItem() { Page = "/Views/Containers/Cart/Cart.cshtml", Title = "Cart", Link = "/cart" };
        public static readonly RouterItem RemoveCart = new RouterItem() { Page = "/Views/Containers/Cart/Cart.cshtml", Title = "Cart", Link = "/cart/remove" };
    }
}