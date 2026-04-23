namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class SaveThroughXslt
{
  public bool ShouldSerializeSolutionId() => !String.IsNullOrEmpty(SolutionId);
}
