namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Indentation Class.
/// </summary>
public interface IIndentation // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Left Indentation
  /// </summary>
  public System.String? Left { get ; set; }
  
  /// <summary>
  /// start, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? Start { get ; set; }
  
  /// <summary>
  /// Left Indentation in Character Units
  /// </summary>
  public System.Int32? LeftChars { get ; set; }
  
  /// <summary>
  /// startChars, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int32? StartCharacters { get ; set; }
  
  /// <summary>
  /// Right Indentation
  /// </summary>
  public System.String? Right { get ; set; }
  
  /// <summary>
  /// end, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? End { get ; set; }
  
  /// <summary>
  /// Right Indentation in Character Units
  /// </summary>
  public System.Int32? RightChars { get ; set; }
  
  /// <summary>
  /// endChars, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int32? EndCharacters { get ; set; }
  
  /// <summary>
  /// Indentation Removed from First Line
  /// </summary>
  public System.String? Hanging { get ; set; }
  
  /// <summary>
  /// Indentation Removed From First Line in Character Units
  /// </summary>
  public System.Int32? HangingChars { get ; set; }
  
  /// <summary>
  /// Additional First Line Indentation
  /// </summary>
  public System.String? FirstLine { get ; set; }
  
  /// <summary>
  /// Additional First Line Indentation in Character Units
  /// </summary>
  public System.Int32? FirstLineChars { get ; set; }
  
}
