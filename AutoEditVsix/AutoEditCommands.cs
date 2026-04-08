using System;
using System.ComponentModel.Design;
using System.Threading.Tasks;
using EnvDTE;
using EnvDTE80;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;

namespace AutoEdit;

internal static class AutoEditCommands
{
  public static readonly Guid CommandSet = new Guid("a7f1c3d5-6c25-4d78-b8ee-18a0a60f0123");

  public const int AddOpenXmlElementAttributeCommandId = 0x0100;
  public const int AddOpenXmlEnumTypeAttributeCommandId = 0x0101;
  public const int AddOpenXmlPropertyAttributeCommandId = 0x0102;
  public const int AddOpenXmlTypeAttributeCommandId = 0x0103;
  public const int AddPartialToClassCommandId = 0x0104;
  public const int AddPrivateFieldsWithUpdateCommandId = 0x0105;
  public const int GenerateShouldSerializeFunctionsCommandId = 0x0106;
  public const int RemoveDuplicateDocCommentsCommandId = 0x0107;
  public const int FixBackingFieldSpacingCommandId = 0x0108;

  public static async Task InitializeAsync(AsyncPackage package)
  {
    await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync();
    var commandService = await package.GetServiceAsync(typeof(IMenuCommandService)) as OleMenuCommandService;
    if (commandService == null)
      return;

    Register(commandService, package, AddOpenXmlElementAttributeCommandId, AddOpenXmlElementAttribute.Run);
    Register(commandService, package, AddOpenXmlEnumTypeAttributeCommandId, AddOpenXmlEnumTypeAttribute.Run);
    Register(commandService, package, AddOpenXmlPropertyAttributeCommandId, AddOpenXmlPropertyAttribute.Run);
    Register(commandService, package, AddOpenXmlTypeAttributeCommandId, AddOpenXmlTypeAttribute.Run);
    Register(commandService, package, AddPartialToClassCommandId, AddPartialToClass.Run);
    Register(commandService, package, AddPrivateFieldsWithUpdateCommandId, AddPrivateFieldsWithUpdate.Run);
    Register(commandService, package, GenerateShouldSerializeFunctionsCommandId, GenerateShouldSerializeFunctions.Run);
    Register(commandService, package, RemoveDuplicateDocCommentsCommandId, RemoveDuplicateDocComments.Run);
    Register(commandService, package, FixBackingFieldSpacingCommandId, AddPrivateFieldsWithUpdate.RunFixBackingFieldSpacing);
  }

  private static void Register(OleMenuCommandService commandService, AsyncPackage package, int commandId, Action<string> action)
  {
    var menuCommandID = new CommandID(CommandSet, commandId);
    var menuItem = new OleMenuCommand(
      (sender, args) =>
      {
        ThreadHelper.JoinableTaskFactory.RunAsync(() => ExecuteOnActiveDocumentAsync(package, action));
      },
      menuCommandID);
    commandService.AddCommand(menuItem);
  }

  private static async Task ExecuteOnActiveDocumentAsync(AsyncPackage package, Action<string> action)
  {
    await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync();

    var dte = await package.GetServiceAsync(typeof(DTE)) as DTE2;
    var document = dte?.ActiveDocument;
    var filePath = document?.FullName;

    if (string.IsNullOrWhiteSpace(filePath))
    {
      VsShellUtilities.ShowMessageBox(
        package,
        "No active document.",
        "AutoEdit",
        OLEMSGICON.OLEMSGICON_INFO,
        OLEMSGBUTTON.OLEMSGBUTTON_OK,
        OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST);
      return;
    }

    action(filePath);
  }
}
