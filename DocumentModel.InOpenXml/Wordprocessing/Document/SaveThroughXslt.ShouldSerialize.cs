namespace DocumentModel.Wordprocessing;

public partial class SaveThroughXslt
{
  public bool ShouldSerializeSolutionId() => SolutionId is not null;
}
