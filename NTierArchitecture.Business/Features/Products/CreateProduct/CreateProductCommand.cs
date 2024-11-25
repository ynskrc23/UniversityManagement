using MediatR;

namespace NTierArchitecture.Business.Features.Products.CreateProduct;
public sealed record CreateProductCommand(
    string Name,
    decimal Price,
    int Quantity,
    bool Status,
    Guid CategoryId) : IRequest<Unit>;
