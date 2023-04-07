namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the ConditionalFormatStyle Class.
/// </summary>
[TypeConverter(typeof(ConditionalFormatStyleTypeConverter))]
public class ConditionalFormatStyle : ModelElement
{

  /// <summary>
  ///   Conditional Formatting Bit Mask
  /// </summary>
  public ConditionalFormatFlags Val { get; set; }

  /// <summary>
  ///   firstRow
  /// </summary>
  [XmlIgnore]
  public Boolean FirstRow
  {
    get => Val.HasFlag(ConditionalFormatFlags.firstRow);
    set
    {
      if (value) Val |= ConditionalFormatFlags.firstRow;
      else Val &= ~ConditionalFormatFlags.firstRow;
    }
  }

  /// <summary>
  ///   lastRow
  /// </summary>
  [XmlIgnore]
  public Boolean LastRow
  {
    get => Val.HasFlag(ConditionalFormatFlags.lastRow);
    set
    {
      if (value) Val |= ConditionalFormatFlags.lastRow;
      else Val &= ~ConditionalFormatFlags.lastRow;
    }
  }

  /// <summary>
  ///   firstColumn
  /// </summary>
  [XmlIgnore]
  public Boolean FirstColumn
  {
    get => Val.HasFlag(ConditionalFormatFlags.firstColumn);
    set
    {
      if (value) Val |= ConditionalFormatFlags.firstColumn;
      else Val &= ~ConditionalFormatFlags.firstColumn;
    }
  }

  /// <summary>
  ///   lastColumn
  /// </summary>
  [XmlIgnore]
  public Boolean LastColumn
  {
    get => Val.HasFlag(ConditionalFormatFlags.lastColumn);
    set
    {
      if (value) Val |= ConditionalFormatFlags.lastColumn;
      else Val &= ~ConditionalFormatFlags.lastColumn;
    }
  }

  /// <summary>
  ///   oddVBand
  /// </summary>
  [XmlIgnore]
  public Boolean OddVerticalBand
  {
    get => Val.HasFlag(ConditionalFormatFlags.oddVBand);
    set
    {
      if (value) Val |= ConditionalFormatFlags.oddVBand;
      else Val &= ~ConditionalFormatFlags.oddVBand;
    }
  }


  /// <summary>
  ///   evenVBand
  /// </summary>
  [XmlIgnore]
  public Boolean EvenVerticalBand
  {
    get => Val.HasFlag(ConditionalFormatFlags.evenVBand);
    set
    {
      if (value) Val |= ConditionalFormatFlags.evenVBand;
      else Val &= ~ConditionalFormatFlags.evenVBand;
    }
  }

  /// <summary>
  ///   oddHBand
  /// </summary>
  [XmlIgnore]
  public Boolean OddHorizontalBand
  {
    get => Val.HasFlag(ConditionalFormatFlags.oddHBand);
    set
    {
      if (value) Val |= ConditionalFormatFlags.oddHBand;
      else Val &= ~ConditionalFormatFlags.oddHBand;
    }
  }

  /// <summary>
  ///   evenHBand
  /// </summary>
  [XmlIgnore]
  public Boolean EvenHorizontalBand
  {
    get => Val.HasFlag(ConditionalFormatFlags.evenHBand);
    set
    {
      if (value) Val |= ConditionalFormatFlags.evenHBand;
      else Val &= ~ConditionalFormatFlags.evenHBand;
    }
  }

  /// <summary>
  ///   firstRowFirstColumn
  /// </summary>
  [XmlIgnore]
  public Boolean FirstRowFirstColumn
  {
    get => Val.HasFlag(ConditionalFormatFlags.firstRowFirstColumn);
    set
    {
      if (value) Val |= ConditionalFormatFlags.firstRowFirstColumn;
      else Val &= ~ConditionalFormatFlags.firstRowFirstColumn;
    }
  }

  /// <summary>
  ///   firstRowLastColumn
  /// </summary>
  [XmlIgnore]
  public Boolean FirstRowLastColumn
  {
    get => Val.HasFlag(ConditionalFormatFlags.firstRowLastColumn);
    set
    {
      if (value) Val |= ConditionalFormatFlags.firstRowLastColumn;
      else Val &= ~ConditionalFormatFlags.firstRowLastColumn;
    }
  }

  /// <summary>
  ///   lastRowFirstColumn
  /// </summary>
  [XmlIgnore]
  public Boolean LastRowFirstColumn
  {
    get => Val.HasFlag(ConditionalFormatFlags.lastRowFirstColumn);
    set
    {
      if (value) Val |= ConditionalFormatFlags.lastRowFirstColumn;
      else Val &= ~ConditionalFormatFlags.lastRowFirstColumn;
    }
  }

  /// <summary>
  ///   lastRowLastColumn
  /// </summary>
  [XmlIgnore]
  public Boolean LastRowLastColumn
  {
    get => Val.HasFlag(ConditionalFormatFlags.lastRowLastColumn);
    set
    {
      if (value) Val |= ConditionalFormatFlags.lastRowLastColumn;
      else Val &= ~ConditionalFormatFlags.lastRowLastColumn;
    }
  }
}