import React, { useEffect, useState } from 'react'

const FetchEmployee = () => {
    const [employees, setEmployees] = useState([]);

    useEffect(() => {
        fetch('http://localhost:5008/api/employees')
            .then((response) => response.json())
            .then((data) => {
                console.log(data);
                setEmployees(data);
            })
            .catch((error) => console.log(error.message))
    },[])

    return (
        <div>
           
            <h2> List  of Employee ha</h2>
            <div>
                {employees.map((x) => (
                    <p key={x.employeeid}> {x.name} </p>
                ))}
            </div>

            
           
        </div>                        
    )
}

export default FetchEmployee