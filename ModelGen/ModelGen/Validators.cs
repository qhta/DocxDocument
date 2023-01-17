namespace ModelGen;

public class Validators: List<DocumentFormat.OpenXml.Framework.IValidator>
{
  public Validators(): base(){}

  public Validators(IEnumerable<DocumentFormat.OpenXml.Framework.IValidator> list) : base(list) { }

}