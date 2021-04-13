using System;

namespace Microsoft.Azure.NotificationHubs.Client
{
    public partial class NotificationHub
    {
        private const string NotImplementedExceptionMessage = "This method is not implemented on .NET Standard platforms. ";

        static string PlatformPushChannel => throw new NotImplementedException(NotImplementedExceptionMessage + nameof(PlatformPushChannel));
        static void PlatformSaveInstallation() => throw new NotImplementedException(NotImplementedExceptionMessage + nameof(PlatformSaveInstallation) + "()");
        static void PlatformInitialize(string connectionString, string hubName) => throw new NotImplementedException(NotImplementedExceptionMessage + nameof(PlatformInitialize) + "()");
        static void PlatformInitialize(IInstallationManagementAdapter installationManagementAdapter) => throw new NotImplementedException(NotImplementedExceptionMessage + nameof(PlatformInitialize) + "()");
        static void PlatformSetEnricher() => throw new NotImplementedException(NotImplementedExceptionMessage + nameof(PlatformSetEnricher) + "()");

        static string PlatformGetUserId() => throw new NotImplementedException(NotImplementedExceptionMessage + nameof(PlatformGetUserId) + "()");
        static void PlatformSetUserId(string value) => throw new NotImplementedException(NotImplementedExceptionMessage + nameof(PlatformSetUserId) + "()");

        #region Tags

        static bool PlatformAddTag(string tag) => throw new NotImplementedException(NotImplementedExceptionMessage + nameof(PlatformAddTag) + "()");
        static bool PlatformAddTags(string[] tags) => throw new NotImplementedException(NotImplementedExceptionMessage + nameof(PlatformAddTags) + "()");
        static void PlatformClearTags() => throw new NotImplementedException(NotImplementedExceptionMessage + nameof(PlatformClearTags) + "()");
        static bool PlatformRemoveTag(string tag) => throw new NotImplementedException(NotImplementedExceptionMessage + nameof(PlatformRemoveTag) + "()");
        static bool PlatformRemoveTags(string[] tags) => throw new NotImplementedException(NotImplementedExceptionMessage + nameof(PlatformRemoveTags) + "()");
        static string[] PlatformGetTags() => throw new NotImplementedException(NotImplementedExceptionMessage + nameof(PlatformGetTags) + "()");

        #endregion

        #region Templates

        static void PlatformSetTemplate(string name, InstallationTemplate template) => throw new NotImplementedException(NotImplementedExceptionMessage + nameof(PlatformSetTemplate) + "()");
        static void PlatformRemoveTemplate(string name) => throw new NotImplementedException(NotImplementedExceptionMessage + nameof(PlatformRemoveTemplate) + "()");
        static InstallationTemplate PlatformGetTemplate(string name) => throw new NotImplementedException(NotImplementedExceptionMessage + nameof(PlatformGetTemplate) + "()");

        #endregion
    }
}
