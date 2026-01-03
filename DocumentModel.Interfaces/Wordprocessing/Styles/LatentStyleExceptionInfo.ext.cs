using System.ComponentModel;
namespace DocumentModel.Wordprocessing;

public partial interface LatentStyleExceptionInfo: INotifyPropertyChanged, INotifyPropertyChanging
{
  /// <summary>
  ///   Primary Style Name.
  /// </summary>
  public string? StyleName { get; set; }

  /// <summary>
  ///   Alternate Style Names.
  /// </summary>
  public ListOf<String>? Aliases { get; set; }


}