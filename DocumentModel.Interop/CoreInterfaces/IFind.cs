using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Provides file search functionality.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind?view=office-pia
/// </remarks>
public partial interface IFind
{
  /// <summary>
  /// Gets or sets the `SearchPath` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.searchpath?view=office-pia
  /// </remarks>
  public string SearchPath { get; set; }
  /// <summary>
  /// Gets or sets the `Name` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.name?view=office-pia
  /// </remarks>
  public string Name { get; set; }
  /// <summary>
  /// Gets or sets the `SubDir` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.subdir?view=office-pia
  /// </remarks>
  public bool SubDir { get; set; }
  /// <summary>
  /// Gets or sets the `Title` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.title?view=office-pia
  /// </remarks>
  public string Title { get; set; }
  /// <summary>
  /// Gets or sets the `Author` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.author?view=office-pia
  /// </remarks>
  public string Author { get; set; }
  /// <summary>
  /// Gets or sets the `Keywords` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.keywords?view=office-pia
  /// </remarks>
  public string Keywords { get; set; }
  /// <summary>
  /// Gets or sets the `Subject` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.subject?view=office-pia
  /// </remarks>
  public string Subject { get; set; }
  /// <summary>
  /// Gets or sets the `Options` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.options?view=office-pia
  /// </remarks>
  public MsoFileFindOptions Options { get; set; }
  /// <summary>
  /// Gets or sets the `MatchCase` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.matchcase?view=office-pia
  /// </remarks>
  public bool MatchCase { get; set; }
  /// <summary>
  /// Gets or sets the `Text` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.text?view=office-pia
  /// </remarks>
  public string Text { get; set; }
  /// <summary>
  /// Gets or sets the `PatternMatch` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.patternmatch?view=office-pia
  /// </remarks>
  public bool PatternMatch { get; set; }
  /// <summary>
  /// Gets or sets the `DateSavedFrom` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.datesavedfrom?view=office-pia
  /// </remarks>
  public object DateSavedFrom { get; set; }
  /// <summary>
  /// Gets or sets the `DateSavedTo` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.datesavedto?view=office-pia
  /// </remarks>
  public object DateSavedTo { get; set; }
  /// <summary>
  /// Gets or sets the `SavedBy` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.savedby?view=office-pia
  /// </remarks>
  public string SavedBy { get; set; }
  /// <summary>
  /// Gets or sets the `DateCreatedFrom` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.datecreatedfrom?view=office-pia
  /// </remarks>
  public object DateCreatedFrom { get; set; }
  /// <summary>
  /// Gets or sets the `DateCreatedTo` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.datecreatedto?view=office-pia
  /// </remarks>
  public object DateCreatedTo { get; set; }
  /// <summary>
  /// Gets or sets the `View` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.view?view=office-pia
  /// </remarks>
  public MsoFileFindView View { get; set; }
  /// <summary>
  /// Gets or sets the `SortBy` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.sortby?view=office-pia
  /// </remarks>
  public MsoFileFindSortBy SortBy { get; set; }
  /// <summary>
  /// Gets or sets the `ListBy` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.listby?view=office-pia
  /// </remarks>
  public MsoFileFindListBy ListBy { get; set; }
  /// <summary>
  /// Gets or sets the `SelectedFile` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.selectedfile?view=office-pia
  /// </remarks>
  public int SelectedFile { get; set; }
  /// <summary>
  /// Gets the `Results` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.results?view=office-pia
  /// </remarks>
  public IFoundFiles Results { get; }
  /// <summary>
  /// Gets or sets the `FileType` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.filetype?view=office-pia
  /// </remarks>
  public int FileType { get; set; }
}
