using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a Document Inspector module in a DocumentInspectors collection.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentinspector?view=office-pia"/>
public interface IDocumentInspector: IInteropObject
{
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentinspector.name?view=office-pia"/>
  public string Name { get; }
  /// <summary>
  /// Gets the `Description` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentinspector.description?view=office-pia"/>
  public string Description { get; }


  #region methods

/// <summary>
  /// Runs the inspector and returns status and results.
  /// </summary>
  /// <param name="status">The `Status` parameter.</param>
  /// <param name="results">The `Results` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentinspector.inspect?view=office-pia"/>
  public void Inspect(out DocInspectorStatus status, out string results);
  /// <summary>
  /// Attempts to fix issues reported by the inspector.
  /// </summary>
  /// <param name="status">The `Status` parameter.</param>
  /// <param name="results">The `Results` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentinspector.fix?view=office-pia"/>
  public void Fix(out DocInspectorStatus status, out string results);

  #endregion methods
}

