using AutoMapper;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Repository.Contracts;
using Services.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ServiceManager : IServiceManager
    {

        private readonly Lazy<IAuthenticationService> _authenticationService;

        //Hateoas için dataShaperı silip bookLinksi ekledik
        public ServiceManager(IRepositoryManager repositoryManager,
            IMapper mapper,
            UserManager<User> userManager,
            IConfiguration configuration)
        {
            _authenticationService = new Lazy<IAuthenticationService>(() =>
            new AuthenticationManager(repositoryManager,mapper, userManager, configuration));
        }

        public IAuthenticationService AuthenticationService => _authenticationService.Value;
    }
}
