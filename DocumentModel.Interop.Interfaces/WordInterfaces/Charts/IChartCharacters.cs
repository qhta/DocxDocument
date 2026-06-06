namespace DocumentModel.Interop.Word;	
/// <summary>
/// Represents characters in an object that contains text.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartcharacters?view=word-pia"/>
public interface IChartCharacters : IInteropObject
{
  /// <summary>
  /// Gets or sets the caption text for the chart characters.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartcharacters.caption?view=word-pia"/>
  public string Caption { get; set; }	
  /// <summary>
  /// Gets the number of characters.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartcharacters.count?view=word-pia"/>
  public int Count { get; }	
  /// <summary>
  /// Gets the font formatting for the chart characters.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartcharacters.font?view=word-pia"/>
  public IChartFont Font { get; }	
  /// <summary>
  /// Gets or sets the text of the chart characters.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartcharacters.text?view=word-pia"/>
  public string Text { get; set; }	
  /// <summary>
  /// Gets or sets the phonetic characters.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartcharacters.phoneticcharacters?view=word-pia"/>
  public string PhoneticCharacters { get; set; }	

  #region methods	
/// <summary>
  /// Deletes the object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartcharacters.delete?view=word-pia"/>
  public void Delete();	
  #endregion methods
}
