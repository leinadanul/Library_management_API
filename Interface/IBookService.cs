using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Manage_Library2._0.Interface
{
    public interface IBookService
    {   ////////////////////////////////////////////////////////////////
        ///////////////////Mostrar todos los libros ////////////////////
        ////////////////////////////////////////////////////////////////
        Task<ServiceResponse<List<GetBookDTO>>> GetAllBooks();


        ////////////////////////////////////////////////////////////////
        //////////////////Mostrar libro por id/////////////////////////
        ////////////////////////////////////////////////////////////////
        Task<ServiceResponse<GetBookDTO>> GetBookById(int id);


        ////////////////////////////////////////////////////////////////
        ///////////////////Agregar Libro////////////////////////////////
        ////////////////////////////////////////////////////////////////

        
        Task<ServiceResponse<List<GetBookDTO>>> AddBook(AddBookDTO NewBook);
        ////////////////////////////////////////////////////////////////
        ///////////////////Actualizar Libro/////////////////////////////
        ////////////////////////////////////////////////////////////////


        //Task<ServiceResponse<GetBookDTO>> Update(UpdateBookDTO updateBook);
    }
}

/*
Task Representa una operación asincrónica que puede devolver un valor T, este valor seria el ServiceResponse, este contiene una lista 
que a su vez Representa una lista fuertemente tipada de objetos a los que se puede acceder por índice. Proporciona métodos para buscar, ordenar y manipular listas
la lsita que contiene es un DTO GetBookDTO ahora tendriamos la funcion que queremos que haga, esta seria obtener toda la lista que estamos buscando con el metodo GET , 
ahora en La clase service de book daremos la funcionalidad 

*/