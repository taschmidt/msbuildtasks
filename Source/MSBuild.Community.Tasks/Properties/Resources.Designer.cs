﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MSBuild.Community.Tasks.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MSBuild.Community.Tasks.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attrib directory &apos;{0}&apos;. {1}.
        /// </summary>
        internal static string AttribDirectory {
            get {
                return ResourceManager.GetString("AttribDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attrib file &apos;{0}&apos;. {1}.
        /// </summary>
        internal static string AttribFile {
            get {
                return ResourceManager.GetString("AttribFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File Not Found: {0}.
        /// </summary>
        internal static string FileNotFound {
            get {
                return ResourceManager.GetString("FileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Local File Not Found: {0}.
        /// </summary>
        internal static string FtpLocalNotFound {
            get {
                return ResourceManager.GetString("FtpLocalNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to   {0}% Complete ({1}).
        /// </summary>
        internal static string FtpPercentComplete {
            get {
                return ResourceManager.GetString("FtpPercentComplete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Transfered {0} ({1}) in {2}.
        /// </summary>
        internal static string FtpTransfered {
            get {
                return ResourceManager.GetString("FtpTransfered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Upload File Complete, {0}.
        /// </summary>
        internal static string FtpUploadComplete {
            get {
                return ResourceManager.GetString("FtpUploadComplete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Uploading &quot;{0}&quot;
        ///   to &quot;{1}&quot;
        ///.
        /// </summary>
        internal static string FtpUploading {
            get {
                return ResourceManager.GetString("FtpUploading", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The URI &quot;{0}&quot; scheme is not valid..
        /// </summary>
        internal static string FtpUriInvalid {
            get {
                return ResourceManager.GetString("FtpUriInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Emailing &quot;{0}&quot;..
        /// </summary>
        internal static string MailEmailing {
            get {
                return ResourceManager.GetString("MailEmailing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;{0}&quot; is not a number..
        /// </summary>
        internal static string MathNotNumber {
            get {
                return ResourceManager.GetString("MathNotNumber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating directory &quot;{0}&quot;..
        /// </summary>
        internal static string MoveCreatesDirectory {
            get {
                return ResourceManager.GetString("MoveCreatesDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not move the file &quot;{0}&quot; to the destination file &quot;{1}&quot;, because the destination is a folder instead of a file. To move the source file into a folder, consider using the DestinationFolder parameter instead of DestinationFiles..
        /// </summary>
        internal static string MoveDestinationIsDirectory {
            get {
                return ResourceManager.GetString("MoveDestinationIsDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to move file &quot;{0}&quot; to &quot;{1}&quot;. {2}.
        /// </summary>
        internal static string MoveError {
            get {
                return ResourceManager.GetString("MoveError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Both &quot;{0}&quot; and &quot;{1}&quot; were specified as input parameters in the project file. Please choose one or the other..
        /// </summary>
        internal static string MoveExactlyOneTypeOfDestination {
            get {
                return ResourceManager.GetString("MoveExactlyOneTypeOfDestination", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Moving file from &quot;{0}&quot; to &quot;{1}&quot;..
        /// </summary>
        internal static string MoveFileComment {
            get {
                return ResourceManager.GetString("MoveFileComment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No destination specified for Move. Please supply either &quot;{0}&quot; or &quot;{1}&quot;..
        /// </summary>
        internal static string MoveNeedsDestination {
            get {
                return ResourceManager.GetString("MoveNeedsDestination", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The source file &quot;{0}&quot; is actually a directory.  The &quot;Move&quot; task does not support moving directories..
        /// </summary>
        internal static string MoveSourceIsDirectory {
            get {
                return ResourceManager.GetString("MoveSourceIsDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find the NUnit Project File open command. Please make sure NUnit is installed..
        /// </summary>
        internal static string NUnitNotFound {
            get {
                return ResourceManager.GetString("NUnitNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &quot;{0}&quot; task was not given a value for the required parameter &quot;{1}&quot;..
        /// </summary>
        internal static string ParameterRequired {
            get {
                return ResourceManager.GetString("ParameterRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Read Windows Registry.
        /// </summary>
        internal static string RegistryRead {
            get {
                return ResourceManager.GetString("RegistryRead", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Write Windows Registry.
        /// </summary>
        internal static string RegistryWrite {
            get {
                return ResourceManager.GetString("RegistryWrite", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot continue service {0} on computer &apos;{1}&apos; as it does not support the pause and continue..
        /// </summary>
        internal static string ServiceCannotContinue {
            get {
                return ResourceManager.GetString("ServiceCannotContinue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot pause service {0} on computer &apos;{1}&apos; as it does not support the pause and continue..
        /// </summary>
        internal static string ServiceCannotPause {
            get {
                return ResourceManager.GetString("ServiceCannotPause", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot stop service {0} on computer &apos;{1}&apos;..
        /// </summary>
        internal static string ServiceCannotStop {
            get {
                return ResourceManager.GetString("ServiceCannotStop", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} service was continued successfully..
        /// </summary>
        internal static string ServiceContinued {
            get {
                return ResourceManager.GetString("ServiceContinued", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} service is continuing ....
        /// </summary>
        internal static string ServiceContinuing {
            get {
                return ResourceManager.GetString("ServiceContinuing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Couldn&apos;t find the &apos;{0}&apos; service on &apos;{1}&apos;.
        /// </summary>
        internal static string ServiceNotFound {
            get {
                return ResourceManager.GetString("ServiceNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot continue service {0} on computer &apos;{1}&apos; as its not currently paused..
        /// </summary>
        internal static string ServiceNotPaused {
            get {
                return ResourceManager.GetString("ServiceNotPaused", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot pause service {0} on computer &apos;{1}&apos; as its not currently started..
        /// </summary>
        internal static string ServiceNotStarted {
            get {
                return ResourceManager.GetString("ServiceNotStarted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} service was paused successfully..
        /// </summary>
        internal static string ServicePaused {
            get {
                return ResourceManager.GetString("ServicePaused", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} service is pausing ....
        /// </summary>
        internal static string ServicePausing {
            get {
                return ResourceManager.GetString("ServicePausing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} service was started successfully..
        /// </summary>
        internal static string ServiceStarted {
            get {
                return ResourceManager.GetString("ServiceStarted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} service is starting ....
        /// </summary>
        internal static string ServiceStarting {
            get {
                return ResourceManager.GetString("ServiceStarting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;{0}&apos; service on &apos;{1}&apos; is &apos;{2}&apos;..
        /// </summary>
        internal static string ServiceStatus {
            get {
                return ResourceManager.GetString("ServiceStatus", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} service was stopped successfully..
        /// </summary>
        internal static string ServiceStopped {
            get {
                return ResourceManager.GetString("ServiceStopped", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} service is stopping ....
        /// </summary>
        internal static string ServiceStopping {
            get {
                return ResourceManager.GetString("ServiceStopping", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Solution file &quot;{0}&quot; not found..
        /// </summary>
        internal static string SolutionNotFound {
            get {
                return ResourceManager.GetString("SolutionNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to LocalPath is not a working subversion copy..
        /// </summary>
        internal static string SvnLocalPathNotWorkCopy {
            get {
                return ResourceManager.GetString("SvnLocalPathNotWorkCopy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to get current date!.
        /// </summary>
        internal static string TimeFormatException {
            get {
                return ResourceManager.GetString("TimeFormatException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Getting current date..
        /// </summary>
        internal static string TimeGettingCurrentDate {
            get {
                return ResourceManager.GetString("TimeGettingCurrentDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;{2}&quot; refers to {0} item(s), and &quot;{3}&quot; refers to {1} item(s). They must have the same number of items..
        /// </summary>
        internal static string TwoVectorsMustHaveSameLength {
            get {
                return ResourceManager.GetString("TwoVectorsMustHaveSameLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to   extracted &quot;{0}&quot;.
        /// </summary>
        internal static string UnzipExtracted {
            get {
                return ResourceManager.GetString("UnzipExtracted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unzip File &quot;{0}&quot;
        ///    to Directory &quot;{1}&quot;
        ///.
        /// </summary>
        internal static string UnzipFileToDirectory {
            get {
                return ResourceManager.GetString("UnzipFileToDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unzipped file &quot;{0}&quot; successfully..
        /// </summary>
        internal static string UnzipSuccessfully {
            get {
                return ResourceManager.GetString("UnzipSuccessfully", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Commitment of change set failed!.
        /// </summary>
        internal static string VaultAddFileCommitFailed {
            get {
                return ResourceManager.GetString("VaultAddFileCommitFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Files added to Vault repository successfully..
        /// </summary>
        internal static string VaultAddFileCommitSucceeded {
            get {
                return ResourceManager.GetString("VaultAddFileCommitSucceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Files specified for addition to repository cannot be found..
        /// </summary>
        internal static string VaultAddFilesException {
            get {
                return ResourceManager.GetString("VaultAddFilesException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file {0} could not be checked in: {1}..
        /// </summary>
        internal static string VaultCheckinFileException {
            get {
                return ResourceManager.GetString("VaultCheckinFileException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File or folder {0} not found for checkin..
        /// </summary>
        internal static string VaultCheckinFileNotFoundException {
            get {
                return ResourceManager.GetString("VaultCheckinFileNotFoundException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The folder {0} could not be checked in: {1}..
        /// </summary>
        internal static string VaultCheckinFolderException {
            get {
                return ResourceManager.GetString("VaultCheckinFolderException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} successfully checked out..
        /// </summary>
        internal static string VaultCheckinSuccessful {
            get {
                return ResourceManager.GetString("VaultCheckinSuccessful", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} successfully checked out..
        /// </summary>
        internal static string VaultCheckoutSuccessful {
            get {
                return ResourceManager.GetString("VaultCheckoutSuccessful", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specified diskfile {0} does not exist..
        /// </summary>
        internal static string VaultDiskFileDoesNotExist {
            get {
                return ResourceManager.GetString("VaultDiskFileDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File [{0}] added to change set..
        /// </summary>
        internal static string VaultFileAddedToChangeSet {
            get {
                return ResourceManager.GetString("VaultFileAddedToChangeSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Folder [{0}] added to change set..
        /// </summary>
        internal static string VaultFolderAddedToChangeSet {
            get {
                return ResourceManager.GetString("VaultFolderAddedToChangeSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Incorrect parameters passed to VaultSession..
        /// </summary>
        internal static string VaultIncorrectParameters {
            get {
                return ResourceManager.GetString("VaultIncorrectParameters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Login to Vault repository failed..
        /// </summary>
        internal static string VaultLoginFailed {
            get {
                return ResourceManager.GetString("VaultLoginFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error validating path &quot;{0}&quot;..
        /// </summary>
        internal static string VaultPathValidationException {
            get {
                return ResourceManager.GetString("VaultPathValidationException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Selection of the repository failed: {0}..
        /// </summary>
        internal static string VaultRepositorySelectionFailure {
            get {
                return ResourceManager.GetString("VaultRepositorySelectionFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File or folder {0} not found for checkout..
        /// </summary>
        internal static string VaultResourceNotFound {
            get {
                return ResourceManager.GetString("VaultResourceNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Set working folder for {0} to {1} from {2}..
        /// </summary>
        internal static string VaultSetNewWorkingFolder {
            get {
                return ResourceManager.GetString("VaultSetNewWorkingFolder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ClientInstance.TreeCache has not been initialized, Common cause is that SelectRepository has not been called sucessfully..
        /// </summary>
        internal static string VaultTreeCacheFailure {
            get {
                return ResourceManager.GetString("VaultTreeCacheFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Successfully undid check out for {0}..
        /// </summary>
        internal static string VaultUndoCheckoutSuccessful {
            get {
                return ResourceManager.GetString("VaultUndoCheckoutSuccessful", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Url specifying vault location is required..
        /// </summary>
        internal static string VaultUrlRequired {
            get {
                return ResourceManager.GetString("VaultUrlRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Username must be set to access repository..
        /// </summary>
        internal static string VaultUsernameRequired {
            get {
                return ResourceManager.GetString("VaultUsernameRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Clearing working folder for {0}..
        /// </summary>
        internal static string VaultWorkingFolderCleared {
            get {
                return ResourceManager.GetString("VaultWorkingFolderCleared", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Restoring working folder for {0} to {1}..
        /// </summary>
        internal static string VaultWorkingFolderRestored {
            get {
                return ResourceManager.GetString("VaultWorkingFolderRestored", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Version file &quot;{0}&quot; not found - creating new file..
        /// </summary>
        internal static string VersionFileNotFound {
            get {
                return ResourceManager.GetString("VersionFileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updated to version {0}.
        /// </summary>
        internal static string VersionModifiedValue {
            get {
                return ResourceManager.GetString("VersionModifiedValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Initialized to version {0}.
        /// </summary>
        internal static string VersionOriginalValue {
            get {
                return ResourceManager.GetString("VersionOriginalValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reading version from file &quot;{0}&quot;..
        /// </summary>
        internal static string VersionRead {
            get {
                return ResourceManager.GetString("VersionRead", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to read version number from &quot;{0}&quot;. {1}.
        /// </summary>
        internal static string VersionReadException {
            get {
                return ResourceManager.GetString("VersionReadException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to write version number to &quot;{0}&quot;. {1}&quot;.
        /// </summary>
        internal static string VersionWriteException {
            get {
                return ResourceManager.GetString("VersionWriteException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wrote version to file &quot;{0}&quot;..
        /// </summary>
        internal static string VersionWrote {
            get {
                return ResourceManager.GetString("VersionWrote", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Web directory {0} does not exist on {1}..
        /// </summary>
        internal static string WebDirectoryInvalidDirectory {
            get {
                return ResourceManager.GetString("WebDirectoryInvalidDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Setting scriptmap for {0} on web directory {1} on {2}..
        /// </summary>
        internal static string WebDirectoryScriptMapUpdate {
            get {
                return ResourceManager.GetString("WebDirectoryScriptMapUpdate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Web directory {0} on {1} does not have a setting called {2}..
        /// </summary>
        internal static string WebDirectorySettingInvalidSetting {
            get {
                return ResourceManager.GetString("WebDirectorySettingInvalidSetting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reading {0} property of web directory {1} on {2}..
        /// </summary>
        internal static string WebDirectorySettingStatusRead {
            get {
                return ResourceManager.GetString("WebDirectorySettingStatusRead", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Setting {0} property of web directory {1} on {2}..
        /// </summary>
        internal static string WebDirectorySettingStatusSet {
            get {
                return ResourceManager.GetString("WebDirectorySettingStatusSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reading Xml Document &quot;{0}&quot;..
        /// </summary>
        internal static string XmlReadDocument {
            get {
                return ResourceManager.GetString("XmlReadDocument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to   {0} node(s) selected for read..
        /// </summary>
        internal static string XmlReadNodes {
            get {
                return ResourceManager.GetString("XmlReadNodes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to XmlRead Result: &quot;{0}&quot;.
        /// </summary>
        internal static string XmlReadResult {
            get {
                return ResourceManager.GetString("XmlReadResult", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updating Xml Document &quot;{0}&quot;..
        /// </summary>
        internal static string XmlUpdateDocument {
            get {
                return ResourceManager.GetString("XmlUpdateDocument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to   {0} node(s) selected for update..
        /// </summary>
        internal static string XmlUpdateNodes {
            get {
                return ResourceManager.GetString("XmlUpdateNodes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to XmlUpdate Wrote: &quot;{0}&quot;..
        /// </summary>
        internal static string XmlUpdateResult {
            get {
                return ResourceManager.GetString("XmlUpdateResult", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Adding Parameter \&quot;{0}\&quot;: \&quot;{1}\&quot;..
        /// </summary>
        internal static string XsltAddingParameter {
            get {
                return ResourceManager.GetString("XsltAddingParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Adding root attribute {0}=\&quot;{1}\&quot;..
        /// </summary>
        internal static string XsltAddingRootAttribute {
            get {
                return ResourceManager.GetString("XsltAddingRootAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating root tag \&quot;{0}\&quot;..
        /// </summary>
        internal static string XsltCreatingRootTag {
            get {
                return ResourceManager.GetString("XsltCreatingRootTag", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No input files..
        /// </summary>
        internal static string XsltNoInputFiles {
            get {
                return ResourceManager.GetString("XsltNoInputFiles", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No root tag inserted..
        /// </summary>
        internal static string XsltNoRootTag {
            get {
                return ResourceManager.GetString("XsltNoRootTag", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to   added &quot;{0}&quot;..
        /// </summary>
        internal static string ZipAdded {
            get {
                return ResourceManager.GetString("ZipAdded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating zip file &quot;{0}&quot;..
        /// </summary>
        internal static string ZipCreating {
            get {
                return ResourceManager.GetString("ZipCreating", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Zip File Not Found: {0}..
        /// </summary>
        internal static string ZipFileNotFound {
            get {
                return ResourceManager.GetString("ZipFileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Created zip file &quot;{0}&quot; successfully..
        /// </summary>
        internal static string ZipSuccessfully {
            get {
                return ResourceManager.GetString("ZipSuccessfully", resourceCulture);
            }
        }
    }
}
