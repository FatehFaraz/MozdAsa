using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MozdAsa.Domain.Entity
{
    public class Company
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "نام شرکت الزامی است")]
        [Display(Name = "نام شرکت")]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "شماره ثبت الزامی است")]
        [RegularExpression(@"\d{5}", ErrorMessage = "مقدار شماره ثبت 5 رقم می باشد")]
        [Display(Name = "شماره ثبت")]
        [MaxLength(10)]
        public string InsertNum { get; set; }

        [Required(ErrorMessage = "وارد کردن شناسه ملی الزامی است")]
        [RegularExpression(@"\d{10}", ErrorMessage = "شناسه ملی 10 رقم می باشد")]
        [Display(Name = "شناسه ملی")]
        [MaxLength(10)]
        public string NatinalCode { get; set; }

        [Required(ErrorMessage = "نام کاربری شرکت را وارد کنید")]
        [StringLength(16, ErrorMessage = "حتما بین 5 تا 16 کاراکتر باشد", MinimumLength = 5)]
        [Display(Name = "نام کاربری")]
        [MaxLength(16)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "رمز عبور شرکت را وارد کنید")]
        [Display(Name = "رمز عبور")]
        [MaxLength(100)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "تایید رمز عبور شرکت را وارد کنید")]
        [Display(Name = "تایید رمز عبور")]
        [MaxLength(100)]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [Display(Name = "پست الکترونیک")]
        [Required(ErrorMessage = "پست الکترونیک را وارد کنید")]
        [RegularExpression("^[a-z0-9_\\+-]+(\\.[a-z0-9_\\+-]+)*@[a-z0-9-]+(\\.[a-z0-9]+)*\\.([a-z]{2,4})$", ErrorMessage = "فرمت ایمیل صحیح نیست")]
        [MaxLength(100)]
        public string Email { get; set; }

        [Display(Name = "شماره همراه")]
        [Required(ErrorMessage = "ورود شماره همراه الزامیست")]
        [RegularExpression(@"\d{11}", ErrorMessage = "شماره همراه حداکثر 10 رقم می باشد ")]
        public string mobile { get; set; }

        [Display(Name = "آدرس")]
        [MaxLength(100)]
        public string Address { get; set; }
    }
}
