﻿// <copyright file="LableBL.cs" company="Fundoo Notes Application">
//     LableBL copyright tag.
// </copyright>

namespace Business.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Business.Interfaces;
    using Common.LableModel;
    using Repository.Entities;
    using Repository.Interfaces;

    /// <summary>
    /// Business Layer for Lable
    /// </summary>
    /// <seealso cref="Business.Interfaces.ILableBL" />
    public class LableBL : ILableBL
    {
        /// <summary>
        /// The lable rl
        /// </summary>
        private readonly ILableRL lableRL;

        /// <summary>
        /// Initializes a new instance of the <see cref="LableBL"/> class.
        /// </summary>
        /// <param name="lableRL">The lable rl.</param>
        public LableBL(ILableRL lableRL)
        {
            this.lableRL = lableRL;
        }

        /// <summary>
        /// Creates the lable.
        /// </summary>
        /// <param name="notesId">The notes identifier.</param>
        /// <param name="jwtUserId">The JWT user identifier.</param>
        /// <param name="model">The model.</param>
        public LableResponseModel CreateLable(long notesId, long jwtUserId, LableModel model)
        {
            try
            {
                return this.lableRL.CreateLable(notesId, jwtUserId, model);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// Deletes the lable.
        /// </summary>
        /// <param name="lable">The lable.</param>
        /// <param name="jwtUserId">The JWT user identifier.</param>
        public void DeleteLable(FundooLable lable, long jwtUserId)
        {
            try
            {
                this.lableRL.DeleteLable(lable, jwtUserId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets all lable.
        /// </summary>
        /// <param name="jwtUserId">The JWT user identifier.</param>
        public LableResponseModel GetAllLable(long jwtUserId)
        {
            try
            {
                return this.lableRL.GetAllLable(jwtUserId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets the lables with identifier.
        /// </summary>
        /// <param name="lableId">The lable identifier.</param>
        /// <param name="jwtUserId">The JWT user identifier.</param>
        public FundooLable GetLablesWithId(long lableId, long jwtUserId)
        {
            try
            {
                return this.lableRL.GetLablesWithId(lableId, jwtUserId);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        /// <summary>
        /// Gets the lable with identifier.
        /// </summary>
        /// <param name="lableId">The lable identifier.</param>
        /// <param name="jwtUserId">The JWT user identifier.</param>
        public LableResponseModel GetLableWithId(long lableId, long jwtUserId)
        {
            try
            {
                return this.lableRL.GetLableWithId(lableId, jwtUserId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// Updates the lable.
        /// </summary>
        /// <param name="updateLable">The update lable.</param>
        /// <param name="model">The model.</param>
        /// <param name="jwtUserId">The JWT user identifier.</param>
        public LableResponseModel UpdateLable(FundooLable updateLable, UpdateLableModel model, long jwtUserId)
        {
            try
            {
               return this.lableRL.UpdateLable(updateLable, model, jwtUserId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// Adds the lable.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="jwtUserId">The JWT user identifier.</param>
        public LableResponseModel AddLable(LableModel model, long jwtUserId)
        {
            try
            {
                return this.lableRL.AddLable(model, jwtUserId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
