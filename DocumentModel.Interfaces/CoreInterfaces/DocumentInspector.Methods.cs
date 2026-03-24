using System.Reflection;

namespace DocumentModel.Interfaces;

/// <summary>
/// Represents a Document Inspector module in a DocumentInspectors collection.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentinspector?view=office-pia"/>
public partial interface DocumentInspector
{
  /// <summary>
  /// Runs the inspector and returns status and results.
  /// </summary>
  /// <param name="Status">The `Status` parameter.</param>
  /// <param name="Results">The `Results` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentinspector.inspect?view=office-pia"/>
  public void Inspect(out MsoDocInspectorStatus Status, out string Results);
  /// <summary>
  /// Attempts to fix issues reported by the inspector.
  /// </summary>
  /// <param name="Status">The `Status` parameter.</param>
  /// <param name="Results">The `Results` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentinspector.fix?view=office-pia"/>
  public void Fix(out MsoDocInspectorStatus Status, out string Results);
}

