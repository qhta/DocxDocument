namespace ModelGen;
public class Namespaces: Collection<Namespace>
{
  public Namespaces(){ }

  public Namespaces(IEnumerable<Namespace> collection): base (new List<Namespace>(collection)) { }
}
