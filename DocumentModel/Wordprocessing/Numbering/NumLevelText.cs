namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specifies the textual content which shall be displayed when displaying a paragraph with the given numbering level. 
///   All text in this element's val attribute shall be taken as literal text to be repeated in each instance of this numbering level, 
///   except for any use of the percent symbol (%) followed by a number, 
///   which shall be used to indicate the one-based index of the number to be used at this level. 
///   Any number of a level higher than this level shall be ignored. 
///   When the % syntax is used, the number shall be incremented for each subsequent paragraph of that level (sequential or not), 
///   until the restart level is seen between two subsequent paragraphs of this level. 
/// </summary>
[TypeConverter(typeof(NumLevelTextTypeConverter))]
public class NumLevelText: ModelElement
{
  /// <summary>
  ///   Level Text
  /// </summary>
  public String? Text { get; set; }

  /// <summary>
  ///   Level Text Is Null Character
  /// </summary>
  public Boolean IsNull { get; set; }

  /// <summary>
  /// Default constructor
  /// </summary>
  public NumLevelText() { }

  /// <summary>
  /// Converter for text form
  /// </summary>
  public NumLevelText(string text)
  {
    Text = text;
    IsNull = false;
  }

  /// <summary>
  /// Converter for null form
  /// </summary>
  /// <param name="isNull"></param>
  public NumLevelText(bool isNull)
  {
    Text = null;
    IsNull = isNull;
  }

  /// <summary>
  /// Overriden conversion to string
  /// </summary>
  public override string ToString()
  {
    if (Text != null)
      return Text;
    return $"IsNull = {IsNull}";
  }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public static implicit operator string? (NumLevelText value) => (value.IsNull) ? "\0" : value.Text;
  public static implicit operator NumLevelText (string? str) => (str=="\0") ? new NumLevelText(true) : str!=null 
                                                                            ? new NumLevelText(str) : new NumLevelText();
}