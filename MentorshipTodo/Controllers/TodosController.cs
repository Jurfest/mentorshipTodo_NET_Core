using MentorshipTodo.Communication.Requests;
using MentorshipTodo.Communication.Responses;
using MentorshipTodo.UseCases.GetAll;
using MentorshipTodo.UseCases.GetById;
using MentorshipTodo.UseCases.Register;
using MentorshipTodo.UseCases.Update;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MentorshipTodo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        // GET: api/<TodosController>
        // [HttpGet]
        // public IEnumerable<string> Get()
        // {
        //    return new string[] { "value1", "value2" };
        // }
        
        [HttpGet]
        [ProducesResponseType(typeof(ResponseAllTodosJson), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult GetAll()
        {
            var useCase = new GetAllTodosUseCase();
            
            var response = useCase.Execute();

            if (response.Todos.Count == 0)
            {
                return NoContent();
            }
            
            return Ok(response);
        }

        // GET api/<TodosController>/5
        /*
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        */
        
        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(ResponseTodoJson), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseErrorMessagesJson), StatusCodes.Status404NotFound)]
        public IActionResult GetById([FromRoute] int id)
        {
            var useCase = new GetTodoByIdUseCase();
            var response = useCase.Execute(id);
            return Ok(response);
        }

        /*
        // POST api/<TodosController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
        */
        
        [HttpPost]
        [ProducesResponseType(typeof(ResponseTodoJson), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseErrorMessagesJson), StatusCodes.Status400BadRequest)]
        public IActionResult Register([FromBody] RequestTodoJson request)
        {
            var useCase = new RegisterTodoUseCase();
            var response = useCase.Execute(request);
            return Created(string.Empty, response);
        }

        /*
        // PUT api/<TodosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
        */
        
        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrorMessagesJson), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ResponseErrorMessagesJson), StatusCodes.Status404NotFound)]
        public IActionResult Update([FromRoute] int id, [FromBody] RequestTodoJson request)
        {
            var useCase = new UpdateTodoUseCase();
            useCase.Execute(id, request);
            
            // return Ok("Todo updated successfully.");
            // Comportamento adotado ao realizar o update com sucesso, foi retornar no content | Qual o comportamento mais semântico?
            return NoContent();
        }

        // DELETE api/<TodosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
