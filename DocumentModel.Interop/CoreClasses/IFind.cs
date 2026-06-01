using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Provides file search functionality.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind?view=office-pia"/>
public partial class IFind
{
  /// <summary>
  /// Gets or sets the `SearchPath` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.searchpath?view=office-pia"/>
  public string SearchPath { get; set; }
  /// <summary>
  /// Gets or sets the `Name` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.name?view=office-pia"/>
  public string Name { get; set; }
  /// <summary>
  /// Gets or sets the `SubDir` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.subdir?view=office-pia"/>
  public bool SubDir { get; set; }
  /// <summary>
  /// Gets or sets the `Title` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.title?view=office-pia"/>
  public string Title { get; set; }
  /// <summary>
  /// Gets or sets the `Author` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.author?view=office-pia"/>
  public string Author { get; set; }
  /// <summary>
  /// Gets or sets the `Keywords` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.keywords?view=office-pia"/>
  public string Keywords { get; set; }
  /// <summary>
  /// Gets or sets the `Subject` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.subject?view=office-pia"/>
  public string Subject { get; set; }
  /// <summary>
  /// Gets or sets the `Options` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.options?view=office-pia"/>
  public FileFindOptions Options { get; set; }
  /// <summary>
  /// Gets or sets the `MatchCase` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.matchcase?view=office-pia"/>
  public bool MatchCase { get; set; }
  /// <summary>
  /// Gets or sets the `Text` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.text?view=office-pia"/>
  public string Text { get; set; }
  /// <summary>
  /// Gets or sets the `PatternMatch` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.patternmatch?view=office-pia"/>
  public bool PatternMatch { get; set; }
  /// <summary>
  /// Gets or sets the `DateSavedFrom` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.datesavedfrom?view=office-pia"/>
  public object DateSavedFrom { get; set; }
  /// <summary>
  /// Gets or sets the `DateSavedTo` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.datesavedto?view=office-pia"/>
  public object DateSavedTo { get; set; }
  /// <summary>
  /// Gets or sets the `SavedBy` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.savedby?view=office-pia"/>
  public string SavedBy { get; set; }
  /// <summary>
  /// Gets or sets the `DateCreatedFrom` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.datecreatedfrom?view=office-pia"/>
  public object DateCreatedFrom { get; set; }
  /// <summary>
  /// Gets or sets the `DateCreatedTo` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.datecreatedto?view=office-pia"/>
  public object DateCreatedTo { get; set; }
  /// <summary>
  /// Gets or sets the `View` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.view?view=office-pia"/>
  public FileFindView View { get; set; }
  /// <summary>
  /// Gets or sets the `SortBy` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.sortby?view=office-pia"/>
  public FileFindSortBy SortBy { get; set; }
  /// <summary>
  /// Gets or sets the `ListBy` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.listby?view=office-pia"/>
  public FileFindListBy ListBy { get; set; }
  /// <summary>
  /// Gets or sets the `SelectedFile` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.selectedfile?view=office-pia"/>
  public int SelectedFile { get; set; }
  /// <summary>
  /// Gets the `Results` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.results?view=office-pia"/>
  public IFoundFiles Results { get; }
  /// <summary>
  /// Gets or sets the `FileType` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.filetype?view=office-pia"/>
  public int FileType { get; set; }
}

