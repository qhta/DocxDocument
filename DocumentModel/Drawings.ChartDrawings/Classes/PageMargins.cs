namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the PageMargins Class.
/// </summary>
public class PageMargins: ModelElement
{
  /// <summary>
  ///   l, this property is only available in Office 2016 and later.
  /// </summary>
  public Double? L { get; set; }

  /// <summary>
  ///   r, this property is only available in Office 2016 and later.
  /// </summary>
  public Double? R { get; set; }

  /// <summary>
  ///   t, this property is only available in Office 2016 and later.
  /// </summary>
  public Double? T { get; set; }

  /// <summary>
  ///   b, this property is only available in Office 2016 and later.
  /// </summary>
  public Double? B { get; set; }

  /// <summary>
  ///   header, this property is only available in Office 2016 and later.
  /// </summary>
  public Double? Header { get; set; }

  /// <summary>
  ///   footer, this property is only available in Office 2016 and later.
  /// </summary>
  public Double? Footer { get; set; }
}