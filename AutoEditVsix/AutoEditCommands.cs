using System;
using System.Collections.Generic;
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
  public const int AddXmlRootAttributeCommandId = 0x0109;

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
    Register(commandService, package, AddXmlRootAttributeCommandId, AddXmlRootAttribute.Run);
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
    if (dte == null)
      return;

    var filePaths = new List<string>();
    var filePathSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
    var selectedItems = dte.SelectedItems;
    if (selectedItems is { Count: > 0 })
    {
      for (var i = 1; i <= selectedItems.Count; i++)
      {
        try
        {
          var selectedItem = selectedItems.Item(i);
          if (selectedItem == null)
            continue;

          CollectFilePaths(selectedItem, filePathSet, filePaths);
        }
        catch
        {
        }
      }
    }

    if (filePaths.Count == 0)
    {
      var filePath = dte.ActiveDocument?.FullName;
      if (!string.IsNullOrWhiteSpace(filePath) && filePathSet.Add(filePath))
        filePaths.Add(filePath);
    }

    if (filePaths.Count == 0)
    {
      VsShellUtilities.ShowMessageBox(
        package,
        "No selected or active document.",
        "AutoEdit",
        OLEMSGICON.OLEMSGICON_INFO,
        OLEMSGBUTTON.OLEMSGBUTTON_OK,
        OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST);
      return;
    }

    foreach (var filePath in filePaths)
    {
      if (!IsDocumentOpen(dte, filePath))
      {
        try
        {
          dte.ItemOperations.OpenFile(filePath, EnvDTE.Constants.vsViewKindTextView);
        }
        catch
        {
        }
      }
      try
      {
        action(filePath);
      }
      catch
      {
      }

    }
  }

  private static bool IsDocumentOpen(DTE2 dte, string filePath)
  {
    foreach (Document document in dte.Documents)
    {
      if (string.Equals(document.FullName, filePath, StringComparison.OrdinalIgnoreCase))
        return true;
    }

    return false;
  }

  private static void CollectFilePaths(SelectedItem selectedItem, HashSet<string> filePathSet, List<string> filePaths)
  {
    ThreadHelper.ThrowIfNotOnUIThread();

    var projectItem = selectedItem.ProjectItem;
    if (projectItem != null)
      CollectFilePathsFromProjectItem(projectItem, filePathSet, filePaths);

    var project = selectedItem.Project;
    if (project != null)
      CollectFilePathsFromProject(project, filePathSet, filePaths);
  }

  private static void CollectFilePathsFromProject(Project project, HashSet<string> filePathSet, List<string> filePaths)
  {
    ThreadHelper.ThrowIfNotOnUIThread();

    ProjectItems projectItems;
    try
    {
      projectItems = project.ProjectItems;
    }
    catch
    {
      return;
    }

    if (projectItems == null)
      return;

    for (var i = 1; i <= projectItems.Count; i++)
    {
      try
      {
        var projectItem = projectItems.Item(i);
        if (projectItem != null)
          CollectFilePathsFromProjectItem(projectItem, filePathSet, filePaths);
      }
      catch
      {
      }
    }
  }

  private static void CollectFilePathsFromProjectItem(ProjectItem projectItem, HashSet<string> filePathSet, List<string> filePaths)
  {
    ThreadHelper.ThrowIfNotOnUIThread();

    try
    {
      for (var i = 1; i <= projectItem.FileCount; i++)
      {
        var filePath = projectItem.FileNames[(short)i];
        if (!string.IsNullOrWhiteSpace(filePath) && filePathSet.Add(filePath))
          filePaths.Add(filePath);
      }
    }
    catch
    {
    }

    try
    {
      var subProject = projectItem.SubProject;
      if (subProject != null)
        CollectFilePathsFromProject(subProject, filePathSet, filePaths);
    }
    catch
    {
    }

    ProjectItems childItems;
    try
    {
      childItems = projectItem.ProjectItems;
    }
    catch
    {
      return;
    }

    if (childItems == null)
      return;

    for (var i = 1; i <= childItems.Count; i++)
    {
      try
      {
        var child = childItems.Item(i);
        if (child != null)
          CollectFilePathsFromProjectItem(child, filePathSet, filePaths);
      }
      catch
      {
      }
    }
  }
}
