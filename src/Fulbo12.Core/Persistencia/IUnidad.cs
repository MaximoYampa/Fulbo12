namespace Fulbo12.Core.Persistencia;
public interface IUnidad
{
    IRepoPais RepoPais { get; }
    void Guardar();
}