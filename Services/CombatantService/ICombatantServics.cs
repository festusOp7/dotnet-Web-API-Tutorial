using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet_Web_API_Tutorial.Models;

namespace dotnet_Web_API_Tutorial.Services.CombatantService
{
    public interface ICombatantService
    {
        
         Task<ServiceResponse<List<Character>>> GetAllCombatants();
         Task<ServiceResponse<Character>> GetCombatanatByID(int id);
         Task<ServiceResponse<List<Character>>> AddComatant(Character newCombatant);
         Task<ServiceResponse<Character>> updateCharacter(Character updatedCombatant);
         Task<ServiceResponse<List<Character>>> DeleteCombatant(int id);
    }
}