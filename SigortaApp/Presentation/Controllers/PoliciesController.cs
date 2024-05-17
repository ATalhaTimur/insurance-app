using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    [Route("api/")]
    [ApiController]
    public class PoliciesController : ControllerBase
    {
        private readonly IServiceManager _manager;
        private readonly ILogger<PoliciesController> _logger;

        public PoliciesController(IServiceManager manager, ILogger<PoliciesController> logger)
        {
            _manager = manager;
            _logger = logger;
        }

        // Logger tanımlaması

        [HttpPost("policies/create")]
        public IActionResult CreatePolicy([FromBody] Policies policy)
        {
            try
            {
                if (policy == null)
                {
                    return BadRequest("Gönderilen policy nesnesi boş olamaz.");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                _manager.PolicyService.CreatePolicy(policy);
                return StatusCode(201, policy);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Policy oluşturulurken bir hata oluştu");
                return StatusCode(500, "İç sunucu hatası, detaylar için logları inceleyin.");
            }
        }




        [HttpGet("policies")]
        public IActionResult GetAllPolices()
        {
            try
            {
                var policies = _manager.PolicyService.GetAllPolicies(false);
                return Ok(policies);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Policies alınırken bir hata oluştu");
                return StatusCode(500, "İç sunucu hatası, detaylar için logları inceleyin.");
            }
        }

        [HttpGet("policies/policyId/{id:int}")]
        public IActionResult GetPolicyWithId([FromRoute(Name = "id")] int id)
        {
            try
            {
                var policy = _manager.PolicyService.GetPolicyWithPolicyId(id, false);
                if (policy == null)
                {
                    return NotFound();
                }
                return Ok(policy);
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"ID ile policy alınırken hata oluştu: {id}");
                return StatusCode(500, "İç sunucu hatası, detaylar için logları inceleyin.");
            }
        }


        [HttpGet("policies/userId/{userId:int}")]
        public IActionResult GetPoliciesWithUserID([FromRoute(Name = "userId")] int userId)
        {
            try
            {
                var policies = _manager.PolicyService.GetPoliciesWithUserId(userId, false);

                if (policies == null || !policies.Any())
                {
                    return NotFound($"No policies found for user ID {userId}.");
                }
                return Ok(policies);
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"Error retrieving policies for user ID: {userId}");
                return StatusCode(500, "Internal server error, check logs for details.");
            }
        }

        [HttpPost("Users/create")]
        public IActionResult CreateUser([FromBody] Users user)
        {
            try
            {
                if (user == null)
                {
                    return BadRequest("Gönderilen user nesnesi boş olamaz.");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                _manager.UsersService.CreateUser(user);
                return StatusCode(201, user);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "User oluşturulurken bir hata oluştu");
                return StatusCode(500, "İç sunucu hatası, detaylar için logları inceleyin.");
            }
        }



        [HttpGet("Users")]
        public IActionResult GetAllUsers()
        {
            try
            {
                var users = _manager.UsersService.GetAllUsers(false);
                return Ok(users);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Users alınırken bir hata oluştu");
                return StatusCode(500, "İç sunucu hatası, detaylar için logları inceleyin.");
            }
        }

        [HttpGet("users/usersId/{id:int}")]
        public IActionResult GetUserWithUserId([FromRoute(Name = "id")] int id)
        {
            try
            {
                var user = _manager.UsersService.GetUserWithUserId(id, false);
                if (user == null)
                {
                    return NotFound($"User with ID {id} not found.");
                }
                return Ok(user);
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"Error retrieving user with ID: {id}");
                return StatusCode(500, "Internal server error, check logs for details.");
            }
        }

        [HttpGet("users/ValidateUserWithMail")] //GET /users/ValidateUserWithMail?email=user@example.com&password=12345

        public IActionResult ValidateUserWithMail([FromQuery] string email, [FromQuery] string password)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                return BadRequest("E-posta veya şifre boş olamaz.");
            }

            var user = _manager.UsersService.GetValidateUserWithMail(email, password, trackChanges: false);

            if (user == null)
            {
                return NotFound("Kullanıcı bulunamadı.");
            }

            return Ok(new { UserId = user.Id }); // Yalnızca kullanıcının ID'sini döndür
        }

        [HttpGet("users/ValidateUserWithPhoneNumber")] //GET /users/ValidateUserWithPhoneNumber?phoneNumber=1234567890&password=yourPassword

        public IActionResult ValidateUserWithPhoneNumber([FromQuery] string phoneNumber, [FromQuery] string password)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber) || string.IsNullOrWhiteSpace(password))
            {
                return BadRequest("Telefon numarası veya şifre boş olamaz.");
            }

            var user = _manager.UsersService.GetValidateUserWithPhoneNumber(phoneNumber, password, trackChanges: false);

            if (user == null)
            {
                return NotFound("Kullanıcı bulunamadı.");
            }

            return Ok(new { UserId = user.Id }); // Yalnızca kullanıcının ID'sini döndür
        }

        [HttpPost("transactions/create")]
        public IActionResult CreateTransaction([FromBody] Transactions transactions)
        {
            try
            {
                if (transactions == null)
                {
                    return BadRequest("Gönderilen transactions nesnesi boş olamaz.");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                _manager.TransactionsService.CreateTransaction(transactions);

                return StatusCode(201, transactions);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Transaction oluşturulurken bir hata oluştu");
                return StatusCode(500, "İç sunucu hatası, detaylar için logları inceleyin.");
            }
        }



        [HttpGet("transactions")]
        public IActionResult GetAllTransactions()
        {
            try
            {
                var transactions = _manager.TransactionsService.GetAllTransactions(false);
                return Ok(transactions);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Transactions alınırken bir hata oluştu");
                return StatusCode(500, "İç sunucu hatası, detaylar için logları inceleyin.");
            }
        }


        [HttpGet("transactions/transactionsId/{id:int}")]
        public IActionResult GetTransactionWithTransactionId([FromRoute(Name = "id")] int id)
        {
            try
            {
                var transaction = _manager.TransactionsService.GetTransactionWithTransactionId(id, false);
                if (transaction == null)
                {
                    return NotFound($"Transaction with ID {id} not found.");
                }
                return Ok(transaction);
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"Error retrieving transaction with ID: {id}");
                return StatusCode(500, "Internal server error, check logs for details.");
            }
        }

        [HttpGet("transactions/transactionsWithPolicyId/{id:int}")]
        public IActionResult GetTransactionsWithPolicyId([FromRoute(Name = "id")] int id)
        {
            try
            {
                var transactions = _manager.TransactionsService.GetTransactionsWithPolicyId(id, false);
                if (transactions == null || !transactions.Any())
                {
                    return NotFound($"No transactions found for policy ID {id}.");
                }
                return Ok(transactions);
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"Error retrieving transactions for policy ID: {id}");
                return StatusCode(500, "Internal server error, check logs for details.");
            }
        }

        [HttpGet("transactions/transactionsWithUserId/{id:int}")]
        public IActionResult GetTransactionsWithUserId([FromRoute(Name = "id")] int id)
        {
            try
            {
                var transactions = _manager.TransactionsService.GetTransactionsWithUserId(id, false);
                if (transactions == null || !transactions.Any())
                {
                    return NotFound($"No transactions found for user ID {id}.");
                }
                return Ok(transactions);
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"Error retrieving transactions for user ID: {id}");
                return StatusCode(500, "Internal server error, check logs for details.");
            }
        }

        [HttpPost("policyusers/create")]
        public IActionResult CreatePolicyUser([FromBody] PolicyUser policyUser)
        {
            try
            {
                if (policyUser == null)
                {
                    return BadRequest("Gönderilen policyUser nesnesi boş olamaz.");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                _manager.PolicyUserService.CreatePolicyUser(policyUser);
                return StatusCode(201, policyUser);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "PolicyUser oluşturulurken bir hata oluştu");
                return StatusCode(500, "İç sunucu hatası, detaylar için logları inceleyin.");
            }
        }



        [HttpGet("policyusers")]
        public IActionResult GetAllPolicyUsers()
        {
            try
            {
                var policyUsers = _manager.PolicyUserService.GetAllPolicyUsers(false);
                return Ok(policyUsers);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "PolicyUsers alınırken bir hata oluştu");
                return StatusCode(500, "İç sunucu hatası, detaylar için logları inceleyin.");
            }
        }
        [HttpGet("policyusers/policyId/{id:int}")]
        public IActionResult GetPolicyUserWithPolicyId([FromRoute(Name = "id")] int id)
        {
            try
            {
                var policyUser = _manager.PolicyUserService.GetPolicyUserWithPolicyId(id, false);
                if (policyUser == null)
                {
                    return NotFound($"PolicyUser with ID {id} not found.");
                }
                return Ok(policyUser);
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"Error retrieving policyUser with ID: {id}");
                return StatusCode(500, "Internal server error, check logs for details.");
            }
        }

        [HttpGet("policyusers/policyUserId/{id:int}")]
        public IActionResult GetPolicyUserWithPolicyUserId([FromRoute(Name = "id")] int id)
        {
            try
            {
                var policyUser = _manager.PolicyUserService.GetPolicyUserWithPolicyUserId(id, false);
                if (policyUser == null)
                {
                    return NotFound($"PolicyUser with ID {id} not found.");
                }
                return Ok(policyUser);
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"Error retrieving policyUser with ID: {id}");
                return StatusCode(500, "Internal server error, check logs for details.");
            }
        }

        [HttpGet("policyusers/userId/{id:int}")]
        public IActionResult GetPolicyUserWithUserId([FromRoute(Name = "id")] int id)
        {
            try
            {
                var policyUser = _manager.PolicyUserService.GetPolicyUserWithUserId(id, false);
                if (policyUser == null)
                {
                    return NotFound($"PolicyUser with ID {id} not found.");
                }
                return Ok(policyUser);
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"Error retrieving policyUser with ID: {id}");
                return StatusCode(500, "Internal server error, check logs for details.");
            }
        }


    }
}
