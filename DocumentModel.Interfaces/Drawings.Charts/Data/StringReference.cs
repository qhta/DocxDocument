namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a reference to string data for a chart.
///   This interface defines the formula used to retrieve the string data, the cache of string values, and any extension lists.
/// </summary>
public interface StringReference
{
  /// <summary>
  ///   Formula used to reference the string data.
  /// </summary>
  public string? Formula { get; set; }

  /// <summary>
  ///   Cache of string values referenced by the formula.
  /// </summary>
  public StringCache? StringCache { get; set; }

  /// <summary>
  ///   Collection of extension elements for additional string reference properties.
  /// </summary>
  public StrRefExtensionList? StrRefExtensionList { get; set; }
}