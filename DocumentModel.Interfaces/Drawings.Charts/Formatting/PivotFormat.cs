using System;

namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the formatting properties for a pivot chart element.
/// </summary>
public interface PivotFormat : CollectionItem
{
  /// <summary>
  /// Index of the pivot format in the collection.
  /// </summary>
  public UInt32? Index { get; set; }

  /// <summary>
  /// Shape properties applied to the pivot element.
  /// </summary>
  public ShapeProperties? ShapeProperties { get; set; }

  /// <summary>
  /// Marker properties for the data point.
  /// </summary>
  public Marker? Marker { get; set; }

  /// <summary>
  /// Data label associated with the pivot format.
  /// </summary>
  public DataLabel? DataLabel { get; set; }

  /// <summary>
  /// Extensibility container for future feature extensions.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}