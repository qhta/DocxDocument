namespace DocumentModel.Drawing.Charts;

/// <summary>
/// True if we should render datalabels over the maximum scale.
/// </summary>
public class ShowDataLabelsOverMaximum: IShowDataLabelsOverMaximum
{
  /// <summary>
  /// Boolean Value
  /// </summary>
  public bool? Val
  {
    get;
    set;
  }
  
}
