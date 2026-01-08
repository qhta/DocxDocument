namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents an entry in the data label field table for a chart.
///   Each entry defines a custom field used in data labels, including its unique identifier, formula, and cached values.
/// </summary>
public interface DataLabelFieldTableEntry: CollectionItem
{
  /// <summary>
  ///   Unique identifier (GUID) for the text field associated with this entry.
  /// </summary>
  public string? TextFieldGuid { get; set; }

  /// <summary>
  ///   Formula used to calculate or retrieve the value for this data label field.
  /// </summary>
  public string? Formula { get; set; }

  /// <summary>
  ///   Cache containing the values and metadata for this data label field entry.
  /// </summary>
  public DataLabelFieldTableCache? DataLabelFieldTableCache { get; set; }
}