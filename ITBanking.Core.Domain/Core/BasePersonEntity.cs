namespace ITBanking.Core.Domain.Core;

public class BasePersonEntity : BaseEntity {
  public string FirstName { get; set; } = null!;
  public string LastName { get; set; } = null!;
  public string Email { get; set; } = null!;
  public string DNI { get; set; } = null!;
}
