using Clinix.Core.ValueObjects;

namespace Clinix.Core.Entities;

public class EntityBase
{
    public int Id { get; private set; }
    protected EntityBase() { }

}
