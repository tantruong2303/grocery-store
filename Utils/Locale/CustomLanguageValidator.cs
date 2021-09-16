namespace Backend.Utils.Locale
{
    public class CustomLanguageValidator : FluentValidation.Resources.LanguageManager
    {
        public static class ErrorMessageKey
        {
            public const string ERROR_LOGIN_FAIL = "ERROR_LOGIN_FAIL";
            public const string ERROR_EXISTED = "ERROR_EXISTED";
            public const string ERROR_NOT_ALLOW_ACTION = "ERROR_NOT_ALLOW_ACTION";
            public const string ERROR_NOT_FOUND = "ERROR_NOT_FOUND";
            public const string ERROR_OLD_PASSWORD_NOT_CORRECT = "ERROR_OLD_PASSWORD_NOT_CORRECT";
            public const string ERROR_INVALID_FILE = "ERROR_INVALID_FILE";
            public const string ERROR_UPLOAD_FILE_FAILED = "ERROR_UPLOAD_FILE_FAILED";

        }

        public static class MessageKey
        {

            public const string MESSAGE_LOGIN_SUCCESS = "MESSAGE_LOGIN_SUCCESS";
            public const string MESSAGE_REGISTER_SUCCESS = "MESSAGE_REGISTER_SUCCESS";
            public const string MESSAGE_LOGOUT_SUCCESS = "MESSAGE_LOGOUT_SUCCESS";
            public const string MESSAGE_UPDATE_SUCCESS = "MESSAGE_UPDATE_SUCCESS";
            public const string MESSAGE_ADD_SUCCESS = "MESSAGE_ADD_SUCCESS";
            public const string MESSAGE_DELETE_SUCCESS = "MESSAGE_DELETE_SUCCESS";
        }
        public CustomLanguageValidator()
        {
            // EN


            // Error message
            // EN
            AddTranslation("en", ErrorMessageKey.ERROR_LOGIN_FAIL, "username or password is wrong");
            AddTranslation("en", ErrorMessageKey.ERROR_EXISTED, "is already exist");
            AddTranslation("en", ErrorMessageKey.ERROR_NOT_ALLOW_ACTION, "please login or action is not allow");
            AddTranslation("en", ErrorMessageKey.ERROR_NOT_FOUND, "is not found");
            AddTranslation("en", ErrorMessageKey.ERROR_OLD_PASSWORD_NOT_CORRECT, "password is wrong");
            AddTranslation("en", ErrorMessageKey.ERROR_INVALID_FILE, "file is invalid");
            AddTranslation("en", ErrorMessageKey.ERROR_UPLOAD_FILE_FAILED, "upload file failed");

            // Success message
            // EN
            AddTranslation("en", MessageKey.MESSAGE_LOGIN_SUCCESS, "login success");
            AddTranslation("en", MessageKey.MESSAGE_REGISTER_SUCCESS, "register success");
            AddTranslation("en", MessageKey.MESSAGE_LOGOUT_SUCCESS, "logout success");
            AddTranslation("en", MessageKey.MESSAGE_UPDATE_SUCCESS, "update success");
            AddTranslation("en", MessageKey.MESSAGE_ADD_SUCCESS, "add success");
            AddTranslation("en", MessageKey.MESSAGE_DELETE_SUCCESS, "delete success");

            // Don't touch me please
            AddTranslation("en", "EmailValidator", "is not a valid email address");
            AddTranslation("en", "GreaterThanOrEqualValidator", "should be greater than or equal to {ComparisonValue}");
            AddTranslation("en", "GreaterThanValidator", "should be greater than {ComparisonValue}");
            AddTranslation("en", "LengthValidator", "should be between {MinLength} and {MaxLength} characters");
            AddTranslation("en", "MinimumLengthValidator", "should be at least {MinLength} characters");
            AddTranslation("en", "MaximumLengthValidator", "should be {MaxLength} characters or fewer");
            AddTranslation("en", "LessThanOrEqualValidator", "should be less than or equal to {ComparisonValue}");
            AddTranslation("en", "LessThanValidator", "should be less than {ComparisonValue}");
            AddTranslation("en", "NotEmptyValidator", "should not be empty");
            AddTranslation("en", "NotEqualValidator", "should not be equal to {ComparisonValue}");
            AddTranslation("en", "NotNullValidator", "should not be empty");
            AddTranslation("en", "RegularExpressionValidator", "is not in the correct format");
            AddTranslation("en", "EqualValidator", "should be equal to {ComparisonValue}");
            AddTranslation("en", "ExactLengthValidator", "should be equal to {ComparisonValue}");
            AddTranslation("en", "InclusiveBetweenValidator", "should be between {From} and {To}");
            AddTranslation("en", "ExclusiveBetweenValidator", "should be between {From} and {To} (exclusive)");
            AddTranslation("en", "NullValidator", "must be empty");
            AddTranslation("en", "EmptyValidator", "must be empty");
            AddTranslation("en", "EnumValidator", "has a range of values which does not include {PropertyValue}");
        }
    }
}