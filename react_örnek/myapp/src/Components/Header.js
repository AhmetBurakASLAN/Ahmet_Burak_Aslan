import React from 'react'

function Header() {
  return (
    <nav className="navbar container navbar-expand-md navbar-dark bg-dark">
    <div className="container-fluid">
      <a className="navbar-brand" href="#">
        CineWissen
      </a>
      <button
        className="navbar-toggler"
        type="button"
        data-bs-toggle="collapse"
        data-bs-target="#navbarSupportedContent"
        aria-controls="navbarSupportedContent"
        aria-expanded="false"
        aria-label="Toggle navigation"
      >
        <span className="navbar-toggler-icon" />
      </button>
      <div className="collapse navbar-collapse" id="navbarSupportedContent">
        <ul className="navbar-nav me-auto mb-2 mb-lg-0">
          <li className="nav-item">
            <a className="nav-link active" aria-current="page" href="index.html">
              AnaSayfa
            </a>
          </li>
          <li className="nav-item">
            <a className="nav-link" href="salon1.html">
              Salon-1
            </a>
          </li>
          <li className="nav-item">
            <a className="nav-link" href="#">
              Salon-2
            </a>
          </li>
          <li className="nav-item">
            <a className="nav-link" href="#">
              Salon3
            </a>
          </li>
          <li className="nav-item">
            <a className="nav-link" href="#">
              Salon-4
            </a>
          </li>
          <li className="nav-item">
            <a className="nav-link" href="#">
              Salon-5
            </a>
          </li>
          <li className="nav-item">
            <a className="nav-link" href="#">
              İletişim
            </a>
          </li>
        </ul>
        <form className="d-flex">
          <input
            className="form-control me-2"
            type="search"
            placeholder="Ara..."
            aria-label="Search"
          />
          <button className="btn btn-outline-success" type="submit">
            Ara
          </button>
        </form>
      </div>
    </div>
  </nav>
  
  )
}

export default Header